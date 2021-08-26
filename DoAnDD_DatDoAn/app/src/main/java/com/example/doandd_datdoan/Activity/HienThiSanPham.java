package com.example.doandd_datdoan.Activity;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.widget.FrameLayout;

import com.example.doandd_datdoan.Fragment.ListLoaiCH_Frament;
import com.example.doandd_datdoan.Fragment.ListLoaiSP_Fragment;
import com.example.doandd_datdoan.Fragment.ListSanPham_Fragment;
import com.example.doandd_datdoan.R;
import com.google.android.material.bottomnavigation.BottomNavigationView;

public class HienThiSanPham extends AppCompatActivity {
    FrameLayout layouthoast;
    Fragment hienthifragment;
    BottomNavigationView bottomNavigationView;
    String maLoai, maCH;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hien_thi_san_pham);
        Intent intent = getIntent();
        maLoai = intent.getStringExtra("maLoai");
        maCH = intent.getStringExtra("maCH");

        layouthoast = findViewById(R.id.FL_TrangChu);
        bottomNavigationView = findViewById(R.id.view_Cuoi_bai23);
        LoadFragment(new ListLoaiSP_Fragment(maLoai));
       // hienthifragment = new ListLoaiSP_Fragment(maCH);
        //LoadFragment(new ListLoaiCH_Frament(maCH));
        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                int id = item.getItemId();
                switch (id) {
                    case R.id.home:
                        hienthifragment = new ListSanPham_Fragment();
                        break;
                    case R.id.dashbord:
                        hienthifragment = new ListLoaiSP_Fragment(maCH);
                        break;
                 /*   case R.id.notificaton:
                       // hienthifragment = new ListSanPham();
                        break;*/
                }
                LoadFragment(hienthifragment);
                return false;
            }
        });

    }

    public void LoadFragment(Fragment fragment) {
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.FL_TrangChu, fragment);
        transaction.commit();
    }
}