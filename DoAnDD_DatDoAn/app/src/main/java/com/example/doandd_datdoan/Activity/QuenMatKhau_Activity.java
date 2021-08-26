package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.Statement;

public class QuenMatKhau_Activity extends AppCompatActivity {
    TextView btnxacnhan;
    Button btnquaylai;
    EditText edtpass,edtpasscon;
    Connection conn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_doimatkhau2);
        btnquaylai = findViewById(R.id.bn_TroVe2);
        btnxacnhan = findViewById(R.id.bn_XacNhan);
        edtpass = findViewById(R.id.edtpass1);
        edtpasscon = findViewById(R.id.edtconfirmpass1);
        Intent intent = getIntent();
        String sdt = intent.getStringExtra("sdt");
        btnquaylai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        btnxacnhan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (edtpass.getText().toString().isEmpty()) {
                    edtpass.setError("Pass required");
                    return;
                }
                if (edtpasscon.getText().toString().isEmpty()) {
                    edtpasscon.setError("Password required");
                    return;
                }
                if (edtpass.getText().toString().equals(edtpasscon.getText().toString()) && (doiMatKhau(edtpass.getText().toString(), sdt))) {
                    Intent intent = new Intent(QuenMatKhau_Activity.this, MainActivity.class);
                    intent.putExtra("pass",edtpass.getText().toString());
                    intent.putExtra("taikhoan",sdt);
                    startActivity(intent);
                } else {
                    Toast.makeText(getApplicationContext(), "Đổi mật khẩu không thành công !", Toast.LENGTH_SHORT).show();
                    return;
                }
            }
        });
    }
    private boolean doiMatKhau(String pass,String makh)
    {
        try {
            String sql = String.format("UPDATE KHACHHANG SET MatKhau = '"+pass+"' WHERE MaKH='"+makh+"'");
            KetNoiCSDL con = new KetNoiCSDL();
            conn = con.KetNoiCSDL();
            if(conn!= null) {
                Statement st = conn.createStatement();
                int i = st.executeUpdate(sql);
                if (i >= 1) {
                    return true;
                }
            }

        }
        catch (Exception ex)
        {

        }
        return false;
    }
}