package com.example.doandd_datdoan.Fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Adpater.DonHangCu_Adpater;
import com.example.doandd_datdoan.Class.DonHangCu_Class;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class DonHangCu_Frament extends Fragment {
    DonHangCu_Adpater donHangCu_adpater;
    ArrayList<DonHangCu_Class> donHangCu_classes = new ArrayList<>();
    Connection conn;
    String maKH;
    ListView lv_DSDonHangCu;

    public DonHangCu_Frament(String maKH) {
        this.maKH = maKH;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_lvsanpham, container, false);
    }

    public void LoadDSDatHangCu(String maKH) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select MaDonHang, TenCuaHang, NgayDat, TinhTrang, DiaChiGiaoHang, TongTien, HinhThucThanhToan from DONHANG, CUAHANGMON, KHACHHANG where DONHANG.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and KHACHHANG.MaKH = DONHANG.MaKH and KHACHHANG.MaKH = '"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenCuaHang = rs.getString("TenCuaHang");
                    String ngayDat = rs.getString("NgayDat");
                    String tinhTrang = rs.getString("TinhTrang");
                    String DiaChiGiaoHang = rs.getString("DiaChiGiaoHang");
                    String TongTien = rs.getString("TongTien");
                    Double tt = Double.parseDouble(TongTien);
                    int t = (int)(tt/1000);
                    String HinhThucTT = rs.getString("HinhThucThanhToan");
                    String MaDonHang = rs.getString("MaDonHang");
                    int i =0;
                    String tongMon="";
                    String read2 = "select MaMon  from DONHANG, CHITIETDONHANG where CHITIETDONHANG.MaDonHang = DONHANG.MaDonHang and DONHANG.MaDonHang = '"+MaDonHang+"'";
                    Statement st2 = conn.createStatement();
                    ResultSet rs2 = st2.executeQuery(read2);
                    while (rs2.next()) {
                        i++;
                        tongMon = i+"";
                    }
                    donHangCu_classes.add(new DonHangCu_Class(tinhTrang, ngayDat, tenCuaHang, DiaChiGiaoHang, t+".000đ ", "( "+HinhThucTT+" )", "SL: "+tongMon+" Món"));
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

    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        lv_DSDonHangCu =view.findViewById(R.id.lv_SanPham);
        LoadDSDatHangCu(maKH);
        donHangCu_adpater = new DonHangCu_Adpater(getContext(), donHangCu_classes);
        lv_DSDonHangCu.setAdapter(donHangCu_adpater);
    }
}
