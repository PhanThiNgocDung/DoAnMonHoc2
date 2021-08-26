package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.regex.Pattern;

import de.hdodenhof.circleimageview.CircleImageView;

public class ThongTinKHang_Activity extends AppCompatActivity {
    TextView txt_SDT;
    Connection conn;
    EditText txt_TenKH, edtgmail, edtdiachi, edtngaysinh;
    String name,gmail,diachi,ngaysinh, gioiTinh, hinhanh;
    TextView txt_sdt,bn_QuayVe4,bn_ChinhSuaTT;
    RadioButton rdoNam, rdoNu;
    CircleImageView img_hinhAnhKH;
    Button bn_dangXuat;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_thongtinkhachhang);
        txt_SDT = findViewById(R.id.txt_SDTTT);
        Intent intent = getIntent();
        txt_SDT.setText(intent.getStringExtra("maKH"));
        bn_ChinhSuaTT = findViewById(R.id.bn_ChinhSuaTT);
        bn_QuayVe4 = findViewById(R.id.bn_quaylai4);
        txt_TenKH = findViewById(R.id.txt_HoTenTT);
        edtdiachi = findViewById(R.id.txt_diachiTT);
        edtgmail = findViewById(R.id.txt_gmailTT);
        edtngaysinh = findViewById(R.id.txt_NgaySinhTT);
        txt_sdt = findViewById(R.id.txt_SDTTT);
        rdoNam = findViewById(R.id.radioNam);
        rdoNu = findViewById(R.id.radioNu);
        img_hinhAnhKH = findViewById(R.id.img_hinhanhCTKH);
        bn_dangXuat = findViewById(R.id.bn_DangXuat);
        bn_dangXuat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
               // Intent intent = new Intent(ThongTinKHang_Activity.this, MainActivity.class);
               // startActivity(intent);
                showAlertDialog();
            }
        });

        rdoNam.setChecked(true);
        loadThongTinKhachHang(txt_SDT.getText().toString());
        txt_TenKH.setText(name);
        edtdiachi.setText(diachi);
        edtgmail.setText(gmail);
        edtngaysinh.setText(ngaysinh);
        img_hinhAnhKH.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(getBaseContext(), hinhanh));
        if (gioiTinh.equals("Nam"))
        {
            rdoNam.setChecked(true);
        }
        else {
            rdoNu.setChecked(true);
        }

        bn_QuayVe4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        bn_ChinhSuaTT.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!isValid(edtgmail.getText().toString()) || edtgmail.getText().toString().isEmpty()) {
                    edtgmail.setError("Định dạng gmail không đúng!");
                    return;
                }
                if (edtdiachi.getText().toString().isEmpty()) {
                    edtdiachi.setError("Điền thông tin địa chỉ");
                    return;
                }
                if (txt_TenKH.getText().toString().isEmpty()) {
                    txt_TenKH.setError("Điền họ tên");
                    return;
                }
                if (edtngaysinh.getText().toString().isEmpty()) {
                    edtngaysinh.setError("Điền ngày sinh");
                    return;
                }
                String gioiTinh ="";
                if(rdoNam.isChecked())
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                if (CapNhatTTKH(txt_sdt.getText().toString(),txt_TenKH.getText().toString(),edtdiachi.getText().toString(),edtgmail.getText().toString(),edtngaysinh.getText().toString(),gioiTinh)){
                    Toast.makeText(getApplicationContext(), "Thông tin đã được cập nhật !", Toast.LENGTH_SHORT).show();
                    return;
                }
                else {
                    Toast.makeText(getApplicationContext(), "Thông tin chưa được cập nhật !", Toast.LENGTH_SHORT).show();
                    return;
                }

            }
        });

    }
    private void loadThongTinKhachHang(String maKH) {

        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHACHHANG where MaKH='"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    name = rs.getString("TenKH");
                    gmail = rs.getString("Gmail");
                    diachi = rs.getString("DiaChi");
                    ngaysinh =rs.getString("NgaySinh");
                    gioiTinh = rs.getString("GioiTinh");
                    hinhanh = rs.getString("HinhAnh");


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
    private boolean CapNhatTTKH(String maKH,String tenKh, String diaChi, String gmail, String ngaySinh,String gioiTinh)
    {
        try {
            String sql = String.format("UPDATE KHACHHANG SET TenKH=N'"+tenKh+"', DiaChi=N'"+diaChi+"', Gmail='"+gmail+"', NgaySinh='"+ngaySinh+"', GioiTinh=N'"+gioiTinh+"' WHERE MaKH='"+maKH+"'");
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
    public void showAlertDialog(){
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setTitle("Thông báo");
        builder.setMessage("Bạn có muốn đăng xuất không?");
        builder.setCancelable(false);
        builder.setPositiveButton("Ứ chịu", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                Toast.makeText(ThongTinKHang_Activity.this, "Không thoát được", Toast.LENGTH_SHORT).show();
            }
        });
        builder.setNegativeButton("Đăng xuất", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                 Intent intent = new Intent(ThongTinKHang_Activity.this, MainActivity.class);
                 startActivity(intent);
            }
        });
        AlertDialog alertDialog = builder.create();
        alertDialog.show();

    }
}