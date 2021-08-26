package com.example.doandd_datdoan.Fragment;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Activity.CTCuaHang_Activity;
import com.example.doandd_datdoan.Activity.CTMonAn_Activity;
import com.example.doandd_datdoan.Adpater.MonAn_Adpater;
import com.example.doandd_datdoan.Adpater.SanPhamCoGia_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.Class.QuanBan_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class ListLoaiCH_Frament extends Fragment {
    Connection conn;
    ArrayList<MonAn_Class> monAnArrayList = new ArrayList<>();
    ArrayList<MonAn_Class> monAnArrayList2 = new ArrayList<>();
    SanPhamCoGia_Adpater sanPhamCoGiaAdpater;
    ListView lv;
    String maCuaHang;
    TextView txt_tenCHCT, txt_soCayCTCH, txt_DiaChiCTCH, txt_soSaoCTCH;
    ImageView img_HinhAnhCHCT;
    String tenCH, soCayCH, diaChiCH, soSaoCH;
    String hinhCH;

    public ListLoaiCH_Frament( String maCuaHang) {
        this.maCuaHang = maCuaHang;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_ctcuahang, container, false);
    }
    public  void getTextFormSQL(String maCuaHang)
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select DISTINCT TenMon,MONAN.MaMon as MaMon,  HinhAnhMon ,DiaChi, TenCuaHang,  DanhGia, Gia, HinhAnhCH \n" +
                        " from MONAN, CUAHANGMON, LOAIMON, LICHSUGIA \n" +
                        "where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and CUAHANGMON.MaCuaHangMon = '"+maCuaHang+"' and GETDATE() < NgayHL and LICHSUGIA.MaMon = MONAN.MaMon and SoLuongTon > 0";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenSP = rs.getString("TenMon");
                    String hinhSP = rs.getString("HinhAnhMon");
                    String soSao = rs.getString("DanhGia");
                    String gia = rs.getString("Gia");
                    String maMon = rs.getString("MaMon");
                    Double tt = Double.parseDouble(gia);
                    int t = (int)(tt/1000);
                    tenCH = rs.getString("TenCuaHang");
                    hinhCH = rs.getString("HinhAnhCH");
                    soSaoCH = rs.getString("DanhGia");
                    diaChiCH =rs.getString("DiaChi");

                    monAnArrayList.add(new MonAn_Class(tenSP, hinhSP, soSao, "5km"));
                    monAnArrayList2.add( new MonAn_Class(tenSP, hinhSP, soSao, "5km", "Giá: "+t+".000đ",maCuaHang, maMon));
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
        getTextFormSQL(maCuaHang);
        sanPhamCoGiaAdpater = new SanPhamCoGia_Adpater(getContext(), monAnArrayList2);
        txt_tenCHCT = view.findViewById(R.id.txt_tenQuanCT);
        txt_DiaChiCTCH = view.findViewById(R.id.txt_DiaChiCuaHangCT);
        txt_soCayCTCH = view.findViewById(R.id.txt_soCayCTCH);
        txt_soSaoCTCH = view.findViewById(R.id.txt_soSaoCTCH);
        img_HinhAnhCHCT = view.findViewById(R.id.img_hinhQuanAnCT);
        txt_soCayCTCH.setText("5 km");
        txt_tenCHCT.setText(tenCH);
        txt_soSaoCTCH.setText(soSaoCH);
        txt_DiaChiCTCH.setText(diaChiCH);
       img_HinhAnhCHCT.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(getContext(), hinhCH));

        lv =view.findViewById(R.id.lv_sanpham2);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getActivity(), CTMonAn_Activity.class);
                intent.putExtra("maMonAn", monAnArrayList2.get(position).getMaMonAn());
                intent.putExtra("hinhAnhMonAn", monAnArrayList2.get(position).getHinhSP());
                startActivity(intent);
            }
        });
        lv.setAdapter(sanPhamCoGiaAdpater);

    }
}
