package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Paint;
import android.os.Bundle;
import android.telephony.PhoneNumberUtils;
import android.text.InputType;
import android.text.TextUtils;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DangKi_Activity extends AppCompatActivity {
    EditText txt_SoDT, txt_TenKH, txt_Email, txt_Pass, txt_ResPass;
    Button bn_dangky;
    TextView bn_QuayLai;
    Connection conn;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_dangki);
        txt_SoDT = findViewById(R.id.edtsdt);
        txt_TenKH = findViewById(R.id.edtname);
        txt_Email = findViewById(R.id.edtemail);
        txt_Pass = findViewById(R.id.edtpassword);
        txt_ResPass = findViewById(R.id.edtconfirmpass);
        txt_SoDT.setInputType(InputType.TYPE_CLASS_PHONE);
        Intent intent = getIntent();
        txt_TenKH.setText(intent.getStringExtra("tenFb"));
        txt_Email.setText(intent.getStringExtra("emailFb"));
        bn_dangky = findViewById(R.id.bn_DangKy);
        bn_QuayLai = findViewById(R.id.btnTRoVe);
        bn_QuayLai.setPaintFlags(bn_QuayLai.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);
        bn_QuayLai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        bn_dangky.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (kiemtrDkDangKi())
                {
                    return;
                }
                else
                {
                    if(kiemTraTonTaiKH(txt_SoDT.getText().toString()))
                    {
                        Toast.makeText(getApplicationContext(), "Số điện thoại đã đăng ký vui lòng nhập số điện thoại khác !", Toast.LENGTH_SHORT).show();
                    }
                    else
                    {
                        if(themkhachHang(txt_SoDT.getText().toString(), txt_TenKH.getText().toString(), txt_Pass.getText().toString(), txt_Email.getText().toString()))
                        {
                            Toast.makeText(getApplicationContext(), "Xin chào "+ txt_TenKH.getText().toString(), Toast.LENGTH_LONG).show();

                            /*Intent intent = new Intent(DangKi_Activity.this, MainActivity.class);
                            intent.putExtra("username", txt_SoDT.getText().toString());
                            intent.putExtra("password", txt_Pass.getText().toString());
                            setResult(101, intent);*/
                            finish();
                            //finish();
                        }
                        else
                        {
                            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra lại kết nỗi mạng", Toast.LENGTH_LONG).show();
                            finish();
                        }
                    }
                }


            }
        });
    }
    public  boolean kiemtrDkDangKi()
    {
        if (!isValidPhoneNo(txt_SoDT.getText().toString()))
        {
            txt_SoDT.setError("Vui lòng nhập đúng Số điện thoại");
            return true;
        }
        if (!isValid(txt_Email.getText().toString())) {
            txt_Email.setError("Định dạng gmail không đúng!");
            return true;
        }
        if (txt_TenKH.getText().toString().isEmpty()) {
            txt_TenKH.setError("Họ tên không để trống");
            return true;
        }
        if (txt_Pass.getText().toString().isEmpty()) {
            txt_Pass.setError("Mật khẩu không được để trống");
            return true;
        }
        if (txt_ResPass.getText().toString().isEmpty() || !txt_ResPass.getText().toString().equals(txt_Pass.getText().toString())) {
            txt_ResPass.setError("Vui lòng kiểm tra lại");
            return true;
        }
        if (txt_TenKH.getText().toString().isEmpty()) {
            txt_TenKH.setError("Họ tên không để trống");
            return true;
        }
        return  false;
    }
    private boolean kiemTraTonTaiKH(String maKH)
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHACHHANG where MaKH='"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                        return true;
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {
            return false;
        }
        return false;
    }
    private boolean themkhachHang(String maKH, String tenKH,String matKhau, String gmail)
    {
        try {
            String sql = String.format("INSERT INTO KHACHHANG(MaKH, MatKhau,TenKH,Gmail, HinhAnh, GioiTinh) "
                    + " VALUES('"+maKH+"', '"+matKhau+"',N'"+tenKH+"','"+gmail+"', 'hinhanhdaidien.jpg', 'Nam')");
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
    public static boolean isValidPhoneNo(String iPhoneNo) {
        Pattern pattern = Pattern.compile("\\d{3}\\d{7}");
        Matcher matcher = pattern.matcher(iPhoneNo);
        if (matcher.matches()) {
           return  true;
        }
        return  false;
    }
    public static boolean isValid(String email) {
        String emailRegex = "^[a-zA-Z0-9_+&*-]+(?:\\." +
                "[a-zA-Z0-9_+&*-]+)*@" +
                "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                "A-Z]{2,7}$";
        Pattern pat = Pattern.compile(emailRegex);
        if (email == null)
            return false;
        return pat.matcher(email).matches();
    }
    public void showAlertDialog(String tenThongBao){
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Thông báo đến nè");
        builder.setMessage(tenThongBao);
        builder.setCancelable(false);
        builder.setPositiveButton("Ok", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });
        AlertDialog alertDialog = builder.create();
        alertDialog.show();

    }
}