package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.TextView;

import com.example.doandd_datdoan.Fragment.DiaChiKH_Frament;
import com.example.doandd_datdoan.Fragment.DoiMatKhau_Frament;
import com.example.doandd_datdoan.Fragment.DonHangCu_Frament;
import com.example.doandd_datdoan.Fragment.KhuyenMai_Frament;
import com.example.doandd_datdoan.Fragment.ListLoaiSP_Fragment;
import com.example.doandd_datdoan.R;

public class SuKienTaiKhoan_Activity extends AppCompatActivity {
    FrameLayout layouthoast;
    String giatri;
    String maKH;
    Button bn_QuayLaiTC;
    TextView txt_tenTD;
    String maLoai;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sukienkhachhang);
        layouthoast = findViewById(R.id.Fl_DanhSach);
        bn_QuayLaiTC = findViewById(R.id.bn_QuayLai2);
        txt_tenTD = findViewById(R.id.txt_tieuDeKH);
        bn_QuayLaiTC.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(SuKienTaiKhoan_Activity.this, TrangChinh.class);
                finish();
            }
        });
      //  LoadFragment(new KhuyenMai_Frament());
        Intent intent = getIntent();
        giatri = intent.getStringExtra("giaTri");
        maKH = intent.getStringExtra("maKH");
        maLoai = intent.getStringExtra("maLoai");
        txt_tenTD.setText(intent.getStringExtra("tenTieuDe"));
        if(giatri.equals("2"))
        {
            LoadFragment(new KhuyenMai_Frament());
        }
        else if(giatri.equals("1"))
        {
            LoadFragment(new DonHangCu_Frament(maKH));
        }
        else  if(giatri.equals("3"))
        {
            LoadFragment(new DiaChiKH_Frament(maKH));
        }
        else  if(giatri.equals("4"))
        {
            LoadFragment(new ListLoaiSP_Fragment(maLoai));
        }
        else  if(giatri.equals("5"))
        {
            LoadFragment(new DoiMatKhau_Frament());
        }

    }
    public void LoadFragment(Fragment fragment)
    {
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.Fl_DanhSach, fragment);
        transaction.commit();
    }


}