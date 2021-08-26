package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Adpater.CTDonHang_Adpater;
import com.example.doandd_datdoan.Class.CTDonHang_Class;
import com.example.doandd_datdoan.Class.DiaChiKH_Class;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

public class CTMonAn_Activity extends AppCompatActivity {
    Button bn_CongMon, bn_TruMon, bn_ThenMon;
    TextView txt_SoLuongMon, txt_GiaCTMon, txt_TenMon, bn_Quaylai5;
    int soLuong, giaCTMon , giaMon;
    String maMon;
    Connection conn;
    ImageView img_hinh;
    String tenMon, maCHMon;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_ctmonan);
        bn_CongMon = findViewById(R.id.bn_CongCTMon);
        bn_TruMon = findViewById(R.id.bn_truCTMon);
        txt_SoLuongMon = findViewById(R.id.txt_soLuongCTMon);
        txt_GiaCTMon = findViewById(R.id.txt_GiaCTMon);
        txt_TenMon = findViewById(R.id.txt_tenCTMon);
        img_hinh = findViewById(R.id.img_hinhCTMon);
        bn_Quaylai5 = findViewById(R.id.bn_quaylai5);
        bn_ThenMon = findViewById(R.id.bn_ThemVaoGioHangCTMon);
        bn_Quaylai5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        Intent intent = getIntent();
        maMon = intent.getStringExtra("maMonAn");
        img_hinh.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(getBaseContext(), intent.getStringExtra("hinhAnhMonAn")));
        LoadMonTheoMaMon(maMon);
        soLuong = Integer.parseInt(txt_SoLuongMon.getText().toString());
        bn_CongMon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                soLuong++;
                giaCTMon = soLuong* giaMon;
                txt_GiaCTMon.setText(giaCTMon+".000đ");
                txt_SoLuongMon.setText(soLuong+"");
                bn_ThenMon.setText("THÊM MÓN VÀO GIỎ HÀNG");
            }
        });
        bn_TruMon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(soLuong == 0)
                {
                    soLuong = 0;
                }
                else {
                    soLuong--;
                    if(soLuong ==0)
                    {
                        bn_ThenMon.setText("XÓA MÓN");
                    }

                }
                giaCTMon = soLuong* giaMon;
                txt_GiaCTMon.setText(giaCTMon+".000đ");
                txt_SoLuongMon.setText(soLuong+"");

            }
        });

        bn_ThenMon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if(bn_ThenMon.getText().equals("THÊM MÓN VÀO GIỎ HÀNG"))
                {
                    Intent intent = new Intent(CTMonAn_Activity.this, CTCuaHang_Activity.class);
                    if (CTCuaHang_Activity.ctDonHangClasses.size() == 0)
                    {
                        CTCuaHang_Activity.ctDonHangClasses.add(new CTDonHang_Class(maMon, tenMon, giaCTMon + "", soLuong + "", maCHMon));
                        finish();
                    }
                    else {
                        if(!kiemtratontaigio(maCHMon))
                        {
                            CTCuaHang_Activity.ctDonHangClasses.add(new CTDonHang_Class(maMon, tenMon, giaCTMon + "", soLuong + "", maCHMon));
                            finish();
                        }

                    }
                }
            }
        });
    }
    public boolean kiemtratontaigio(String maCH)
    {
        for (int i = 0; i < CTCuaHang_Activity.ctDonHangClasses.size(); i++) {
            if (maMon.equals(CTCuaHang_Activity.ctDonHangClasses.get(i).getMaMon())) {
                int sl = Integer.parseInt(CTCuaHang_Activity.ctDonHangClasses.get(i).getStt());
                int gia = Integer.parseInt(CTCuaHang_Activity.ctDonHangClasses.get(i).getGiaMon());
                sl++;
                CTCuaHang_Activity.ctDonHangClasses.get(i).setStt((sl)+ "");
                CTCuaHang_Activity.ctDonHangClasses.get(i).setGiaMon((gia+ giaCTMon)+ "");
                finish();
                return  true;
            }
        }
        return false;
    }
    public void LoadMonTheoMaMon(String maMon) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from MONAN, LICHSUGIA where MONAN.MaMon = LICHSUGIA.MaMon and MONAN.MaMon = '"+maMon+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {

                  tenMon  = rs.getString("TenMon");
                  String  gia = rs.getString("Gia");
                    Double tt = Double.parseDouble(gia);
                    giaMon = (int)(tt/1000);
                    giaCTMon = giaMon;
                    txt_TenMon.setText(tenMon);
                    txt_GiaCTMon.setText(giaMon +".000đ");
                    maCHMon = rs.getString("MaCuaHangMon");
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {
             Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
    }
}