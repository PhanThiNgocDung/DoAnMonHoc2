package com.example.doandd_datdoan.Fragment;

import android.app.AlertDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Activity.CTKhuyenMai_Activity;
import com.example.doandd_datdoan.Adpater.KhuyenMai_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.KhuyenMai_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class KhuyenMai_Frament extends Fragment {
    Connection conn;
    ArrayList<KhuyenMai_Class> khuyenMai_classes = new ArrayList<>();
    KhuyenMai_Adpater khuyenMai_adpater;
    ListView lv_DanhSach;
    String maKM;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_lvsanpham, container, false);
    }

    public  void getTextFormSQL()
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHUYENMAI where NgayBDKhuyenMai < GETDATE() and NgayKTKhuyenMai > GETDATE()";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenKM = rs.getString("TenKhuyenMai");
                    String ngayKTKM = rs.getString("NgayKTKhuyenMai");
                    String hinhAnhKM = rs.getString("HinhAnhKM");
                     maKM =  rs.getString("MaKhuyenMai");
                    khuyenMai_classes.add(new KhuyenMai_Class(hinhAnhKM, tenKM,"HSD: " +ngayKTKM));
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {

        }
    }

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        lv_DanhSach =view.findViewById(R.id.lv_SanPham);
        getTextFormSQL();
        khuyenMai_adpater = new KhuyenMai_Adpater(getContext(), khuyenMai_classes);
        lv_DanhSach.setAdapter(khuyenMai_adpater);
        lv_DanhSach.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getActivity(), CTKhuyenMai_Activity.class);
                intent.putExtra("maKM", khuyenMai_classes.get(position).getTenKM());
                startActivity(intent);
            }
        });
    }
    public void ThongBaoKhuyenMai()
    {
        AlertDialog.Builder builder = new AlertDialog.Builder(getContext());
        builder.setTitle("Detail");
        String ma = "Mã giảm giá không áp dụng cho đơn hàng hiện tại bạn đang đặt";
        builder.setMessage(ma);
        AlertDialog alertDialog = builder.create();
        alertDialog.show();
    }
}
