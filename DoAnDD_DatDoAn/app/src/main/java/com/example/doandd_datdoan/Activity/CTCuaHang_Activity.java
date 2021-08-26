package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.graphics.Paint;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.View;
import android.widget.FrameLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Class.CTDonHang_Class;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Fragment.ListLoaiCH_Frament;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class CTCuaHang_Activity extends AppCompatActivity {
    FrameLayout fragment1;
    String maCH, maKH;
    TextView bn_Timkiem2, bn_quaylai4, bn_yeuthich, bn_GioHang;
    public static ArrayList<CTDonHang_Class> ctDonHangClasses = new ArrayList<>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_c_t_cua_hang_);
        fragment1 = findViewById(R.id.Fl_DanhSach3);
        bn_quaylai4 = findViewById(R.id.bn_quaylai4);
        bn_Timkiem2 = findViewById(R.id.bn_timkiem2);
        bn_yeuthich = findViewById(R.id.bn_yeuthich);
        bn_yeuthich.setPaintFlags(bn_yeuthich.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);
        bn_Timkiem2.setPaintFlags(bn_Timkiem2.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);
        bn_quaylai4.setPaintFlags(bn_quaylai4.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);
        bn_quaylai4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        bn_Timkiem2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(CTCuaHang_Activity.this, TimKiem_Activity.class);
                startActivity(intent);
            }
        });
        bn_yeuthich.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //bn_yeuthich.
            }
        });

        Intent intent = getIntent();
        maCH = intent.getStringExtra("maCH");
        maKH = intent.getStringExtra("maKH");
        LoadFragment(new ListLoaiCH_Frament(maCH));
        if (ctDonHangClasses.size() != 0)
        {
            if(!maCH.equals(ctDonHangClasses.get(0).getMaCH()))
            {
                ctDonHangClasses = new ArrayList<>();
            }

        }
        else
        {
            ctDonHangClasses = new ArrayList<>();
        }
        bn_GioHang = findViewById(R.id.bn_gioHang);
        bn_GioHang.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(ctDonHangClasses.size() > 0)
                {
                    int tongTien = 0;
                    Intent intent =new Intent(CTCuaHang_Activity.this, DatMon_Activity.class);
                    for(int i =0; i < ctDonHangClasses.size(); i++)
                    {
                        int tien = Integer.parseInt(ctDonHangClasses.get(i).getGiaMon());
                         tongTien += tien;
                    }
                    intent.putExtra("tongtien", tongTien+".000");
                    intent.putExtra("maKH", maKH);
                    intent.putExtra("maCH", maCH);
                    startActivity(intent);
                }
            }
        });
    }
    public void LoadFragment(Fragment fragment) {
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.Fl_DanhSach3, fragment);
        transaction.commit();
    }
}