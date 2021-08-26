package com.example.doandd_datdoan.Fragment;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Adpater.DiaChiKH_Adpater;
import com.example.doandd_datdoan.Adpater.DonHangCu_Adpater;
import com.example.doandd_datdoan.Class.DiaChiKH_Class;
import com.example.doandd_datdoan.Class.DonHangCu_Class;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class DiaChiKH_Frament extends Fragment {
    DiaChiKH_Adpater diaChiKH_adpater;
    ArrayList<DiaChiKH_Class> diaChiKH_classes = new ArrayList<>();
    Connection conn;
    String maKH;
    ListView lv_DiaChiKH;

    public DiaChiKH_Frament(String maKH) {
        this.maKH = maKH;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_lvsanpham, container, false);
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        lv_DiaChiKH =view.findViewById(R.id.lv_SanPham);
        LoadDSDatHangCu(maKH);
        diaChiKH_adpater = new DiaChiKH_Adpater(getContext(), diaChiKH_classes);
        lv_DiaChiKH.setAdapter(diaChiKH_adpater);
        lv_DiaChiKH.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View convertView, int position, long id) {
               DiaChiKH_Class diaChiKH_class = (DiaChiKH_Class) diaChiKH_adpater.getItem(position);
               if(!CapNhatDiaChiKH(maKH, diaChiKH_class.getDiachiCT()))
               {
                   showAlertDialog("Bạn thay đổi địa chỉ thành công");
               }
            }
        });
    }
    public boolean CapNhatDiaChiKH(String maKH, String diachi)
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String sql = "Update KHACHHANG set DiaChi = N'" + diachi + "' where MaKH ='" + maKH + "'";
                Statement st = conn.createStatement();
                int x = st.executeUpdate(sql);
                if(x > 1)
                {
                    return  true;
                }
            }
        }catch (Exception ex)
        {

        }
        return  false;
    }

    public void LoadDSDatHangCu(String maKH) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select * from DSDIACHI where MaKH = '"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenDiaChi = rs.getString("TenDiaChi");
                    String diaChi = rs.getString("DiaChi");
                    diaChiKH_classes.add(new DiaChiKH_Class(tenDiaChi,"0.05Km", diaChi));
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {
            // Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
    }
    public void showAlertDialog(String tenThongBao){
        androidx.appcompat.app.AlertDialog.Builder builder = new androidx.appcompat.app.AlertDialog.Builder(getContext());
        builder.setTitle("Thông báo đến nè");
        builder.setMessage(tenThongBao);
        builder.setCancelable(false);
        builder.setPositiveButton("Ok", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });
        androidx.appcompat.app.AlertDialog alertDialog = builder.create();
        alertDialog.show();

    }
}
