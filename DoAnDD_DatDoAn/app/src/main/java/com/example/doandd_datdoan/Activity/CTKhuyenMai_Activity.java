package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;

import com.example.doandd_datdoan.Adpater.CTKhuyenMai_Adpater;
import com.example.doandd_datdoan.Adpater.DonHangCu_Adpater;
import com.example.doandd_datdoan.Adpater.KhuyenMai_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.KhuyenMai_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class CTKhuyenMai_Activity extends AppCompatActivity {
    Connection conn;
    ArrayList<KhuyenMai_Class> khuyenMai_classes = new ArrayList<>();
    CTKhuyenMai_Adpater khuyenMai_adpater;
    ListView lv_DanhSach;
    String maKM;
    Button bn_QuayLai;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_c_t_khuyen_mai_);
        Intent intent = getIntent();
        maKM = intent.getStringExtra("maKM");
        lv_DanhSach = findViewById(R.id.lv_CTKhuyenMia);
        bn_QuayLai = findViewById(R.id.bn_QuayLai3);
        bn_QuayLai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(CTKhuyenMai_Activity.this, SuKienTaiKhoan_Activity.class);
                finish();
            }
        });
        getTextFormSQL(maKM);

        khuyenMai_adpater = new CTKhuyenMai_Adpater(getBaseContext(), khuyenMai_classes);
        lv_DanhSach.setAdapter(khuyenMai_adpater);

    }
    public  void getTextFormSQL(String MaKM)
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHUYENMAI where TenKhuyenMai = N'"+MaKM+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenKM = rs.getString("TenKhuyenMai");
                    String ngayKTKM = rs.getString("NgayKTKhuyenMai");
                    String dkKhuyenMai = rs.getString("DKKhuyenMaiCT");
                    String maKM = rs.getString("MaKhuyenMai");
                    khuyenMai_classes.add(new KhuyenMai_Class(tenKM,"Hạn sử dụng: " +ngayKTKM, dkKhuyenMai, maKM ));
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
}