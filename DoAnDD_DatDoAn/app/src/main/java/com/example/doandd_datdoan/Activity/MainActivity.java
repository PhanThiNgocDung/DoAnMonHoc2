package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.drawerlayout.widget.DrawerLayout;

import android.annotation.SuppressLint;
import android.app.AlarmManager;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Intent;
import android.graphics.Paint;
import android.os.Build;
import android.os.Bundle;
import android.text.InputType;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.SearchView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.R;
import com.facebook.AccessToken;
import com.facebook.CallbackManager;
import com.facebook.FacebookCallback;
import com.facebook.FacebookException;
import com.facebook.FacebookSdk;
import com.facebook.GraphRequest;
import com.facebook.GraphResponse;
import com.facebook.login.LoginResult;
import com.facebook.login.widget.LoginButton;

import org.json.JSONException;
import org.json.JSONObject;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Calendar;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import me.gujun.android.taggroup.TagGroup;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = MainActivity.class.getSimpleName();
    TextView txt_QuenMK, txt_DangKi, txt_SoDT, txt_matKhau;
    Connection conn;
    Button bn_DangNhap;
    String TenKH, email,anhKH, diachiKH, maKHT;
    LoginButton bn_DangNhapFB;
    CallbackManager callbackManager;//FB
    String nameFB, emailFB;
    @SuppressLint("WrongViewCast")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //fb
        FacebookSdk.sdkInitialize(this.getApplicationContext());
        callbackManager = CallbackManager.Factory.create();
        //
        setContentView(R.layout.layout_dangnhap);
        txt_DangKi = findViewById(R.id.txt_DangKi);
        txt_QuenMK = findViewById(R.id.txt_QuenMK);
        txt_SoDT = findViewById(R.id.txt_SDT);
        txt_matKhau = findViewById(R.id.txt_MatKhau);
        createNotificationChannel();
        bn_DangNhap = findViewById(R.id.bn_DangNhap);
        bn_DangNhapFB = findViewById(R.id.bn_DangNhapFB);
        bn_DangNhapFB.setReadPermissions("email");

        /*Intent intent = getIntent();
        txt_SoDT.setText(intent.getStringExtra("tk"));
        txt_matKhau.setText(intent.getStringExtra("mk"));*/

        bn_DangNhapFB.registerCallback(callbackManager, new FacebookCallback<LoginResult>() {
            @Override
            public void onSuccess(LoginResult loginResult) {
                result();
                Log.d(TAG, "======Facebook login success======");
                Log.d(TAG, "Facebook Access Token: " + loginResult.getAccessToken().getToken());
                Toast.makeText(MainActivity.this, "Login Facebook success.", Toast.LENGTH_SHORT).show();



            }

            @Override
            public void onCancel() {
                Toast.makeText(MainActivity.this, "Login Facebook cancelled.", Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onError(FacebookException error) {
                Log.e(TAG, "======Facebook login error======");
                Log.e(TAG, "Error: " + error.toString());
                Toast.makeText(MainActivity.this, "Login Facebook error.", Toast.LENGTH_SHORT).show();
            }
        });

        bn_DangNhap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (!isValidPhoneNo(txt_SoDT.getText().toString()))
                {
                    txt_SoDT.setError("Vui lòng nhập đúng Số điện thoại");
                    return;
                }
                else {
                    if (kiemTraTonTaiKH(txt_SoDT.getText().toString())) {
                        if (loadKhachHang()) {

                            Intent intent = new Intent(MainActivity.this, TrangChinh.class);
                            intent.putExtra("tenKH", TenKH);
                            intent.putExtra("emailKH", email);
                            intent.putExtra("anhKH", anhKH);
                            intent.putExtra("diaChiKH", diachiKH);
                            intent.putExtra("maKH", maKHT);

                            //Dat lich vao khung gio co dinh
                            Calendar calendar = Calendar.getInstance();
                            calendar.set(Calendar.HOUR_OF_DAY, 7);
                            calendar.set(Calendar.MINUTE, 41);
                            calendar.set(Calendar.SECOND, 0);

                            //Khoi tao Intent de goi thong bao
                            Intent intent2 = new Intent(getApplicationContext(),ReminderBroadcast.class);
                            //Khai bao PendingIntent de goi Intent vao mot gio co dinh
                            PendingIntent pendingIntent = PendingIntent.getBroadcast(MainActivity.this,100,intent2,0);

                            //Dung AlarmManager de goi PendingIntent vao khung gio co dinh
                            AlarmManager alarmManager =(AlarmManager) getSystemService(ALARM_SERVICE);
                            alarmManager.set(AlarmManager.RTC_WAKEUP,calendar.getTimeInMillis(),pendingIntent);

                            startActivity(intent);

                        }
                        else
                        {
                            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra lại mật khẩu", Toast.LENGTH_LONG).show();
                        }
                    }
                    else
                    {
                        Toast.makeText(getApplicationContext(), "Quý khách chưa đăng kí hay đăng kí mới", Toast.LENGTH_LONG).show();
                    }
                }
            }
        });
        txt_matKhau.setInputType(InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_VARIATION_PASSWORD);
        txt_SoDT.setInputType(InputType.TYPE_CLASS_PHONE);
        txt_QuenMK.setPaintFlags(txt_QuenMK.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);
        txt_DangKi.setPaintFlags(txt_DangKi.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG);

        txt_QuenMK.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, SuKienTaiKhoan_Activity.class);
                intent.putExtra("giaTri", "5");
                intent.putExtra("tenTieuDe", "Đổi mật khẩu");
                startActivity(intent);
            }
        });
        txt_DangKi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this,DangKi_Activity.class);
                startActivity(intent);
            }
        });


    }
    public boolean loadKhachHang()
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHACHHANG";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                   String  maKH = rs.getString("MaKH").trim();
                     TenKH = rs.getString("TenKH");
                      email = rs.getString("Gmail");
                      anhKH = rs.getString("HinhAnh");
                      diachiKH = rs.getString("DiaChi");
                      maKHT = rs.getString("MaKH").trim();
                    String matKhau = rs.getString("MatKhau").trim();
                    if(txt_SoDT.getText().toString().equals(maKH) && txt_matKhau.getText().toString().equals(matKhau))
                    {
                      return true;

                    }

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
    public static boolean isValidPhoneNo(String iPhoneNo) {
        Pattern pattern = Pattern.compile("\\d{3}\\d{7}");
        Matcher matcher = pattern.matcher(iPhoneNo);
        if (matcher.matches()) {
            return  true;
        }
        return  false;
    }
    public void createNotificationChannel() {
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            CharSequence name = "LemubitReminderChannel";
            String description = "Chennel for Lemubit Reminder";
            int importance = NotificationManager.IMPORTANCE_DEFAULT;
            NotificationChannel channel = new NotificationChannel("notifyLemubit", name, importance);
            channel.setDescription(description);

            NotificationManager notificationManager = getSystemService(NotificationManager.class);
            notificationManager.createNotificationChannel(channel);
        }
    }
    private void result() {
        GraphRequest graphRequest = GraphRequest.newMeRequest(AccessToken.getCurrentAccessToken(), new GraphRequest.GraphJSONObjectCallback() {
            @Override
            public void onCompleted(JSONObject object, GraphResponse response) {
                Log.d("JSON",response.getJSONObject().toString());
                try {
                   // Toast.makeText(getApplicationContext(), "Quý khách chưa đăng kí hay đăng kí mới", Toast.LENGTH_LONG).show();
                   nameFB = object.getString("name");
                   emailFB = object.getString("email");
                    Intent intent = new Intent(MainActivity.this, DangKi_Activity.class);
                    intent.putExtra("tenFb", nameFB);
                    intent.putExtra("emailFb", emailFB);
                    startActivity(intent);

                } catch (JSONException e) {
                    e.printStackTrace();
                }

            }
        });
        Bundle parameters = new Bundle();
        parameters.putString("fields", "id,name,email");
        graphRequest.setParameters(parameters);
        graphRequest.executeAsync();
    }
    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        callbackManager.onActivityResult(requestCode, resultCode, data);
    }
}