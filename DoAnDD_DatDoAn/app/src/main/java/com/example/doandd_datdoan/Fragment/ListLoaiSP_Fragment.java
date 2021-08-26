package com.example.doandd_datdoan.Fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Adpater.MonAn_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class ListLoaiSP_Fragment extends Fragment {
    Connection conn;
    ArrayList<MonAn_Class> monAnArrayList = new ArrayList<>();
    MonAn_Adpater monAnAdpater;
    ListView lv;
    String maLoai;

    public ListLoaiSP_Fragment( String maLoai) {
        this.maLoai = maLoai;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_lvsanpham, container, false);
    }
    public  void getTextFormSQL(String maLoai)
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select DISTINCT TenMon, HinhAnhMon, DanhGia from MONAN, CUAHANGMON, LOAIMON where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and MONAN.MaLoaiMon = LOAIMON.MaLoaiMon and LOAIMON.MaLoaiMon = '"+maLoai+"' and SoLuongTon > 0";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenSP = rs.getString("TenMon");
                    String hinhSP = rs.getString("HinhAnhMon");
                    String soSao = rs.getString("DanhGia");
                    monAnArrayList.add(new MonAn_Class(tenSP, hinhSP, soSao, "5km"));
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
        lv =view.findViewById(R.id.lv_SanPham);
        getTextFormSQL(maLoai);
        monAnAdpater = new MonAn_Adpater(getContext(), monAnArrayList);
        lv.setAdapter(monAnAdpater);
    }
}
