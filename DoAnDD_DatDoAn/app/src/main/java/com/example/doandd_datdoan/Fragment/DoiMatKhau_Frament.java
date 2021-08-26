package com.example.doandd_datdoan.Fragment;

import android.app.AlertDialog;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.doandd_datdoan.Activity.DangKi_Activity;
import com.example.doandd_datdoan.Activity.QuenMatKhau_Activity;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DoiMatKhau_Frament extends Fragment {
    TextView btntieptuc;
    EditText edtsdt;
    Connection conn;
    @Override
    public void onViewCreated(@NonNull View view, @Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        btntieptuc = view.findViewById(R.id.bn_TiepTuc);
        edtsdt = view.findViewById(R.id.edtsdt1);
        btntieptuc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!isValidPhoneNo(edtsdt.getText().toString()))
                {
                    edtsdt.setError("Vui lòng nhập đúng Số điện thoại");
                    return;
                }
                if(kiemTraTonTaiKH(edtsdt.getText().toString())){
                    Intent intent=new Intent(getActivity(), QuenMatKhau_Activity.class);
                    intent.putExtra("sdt",edtsdt.getText().toString());
                    startActivity(intent);
                }
                else {
                    AlertDialog.Builder builder = new AlertDialog.Builder(getContext());
                    builder.setTitle("Thông báo");
                    builder.setMessage("Tài khoản chưa đăng kí hãy đăng kí mới ");
                    AlertDialog alertDialog = builder.create();
                    alertDialog.show();
                   /* Intent intent=new Intent(getActivity(), DangKi_Activity.class);
                    startActivity(intent);*/
                }
            }
        });


    }
    public static boolean isValidPhoneNo(String iPhoneNo) {
        Pattern pattern = Pattern.compile("\\d{3}\\d{7}");
        Matcher matcher = pattern.matcher(iPhoneNo);
        if (matcher.matches()) {
            return  true;
        }
        return  false;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        return inflater.inflate(R.layout.layout_doimatkhau, container, false);
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
}
