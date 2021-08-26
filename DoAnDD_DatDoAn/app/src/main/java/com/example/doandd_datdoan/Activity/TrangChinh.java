package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ViewFlipper;

import com.example.doandd_datdoan.Adpater.DonHangCu_Adpater;
import com.example.doandd_datdoan.Adpater.LoaiSanPham_Adpater;
import com.example.doandd_datdoan.Adpater.MonAn_Adpater;
import com.example.doandd_datdoan.Adpater.QuanBan_Adpater;
import com.example.doandd_datdoan.Adpater.SuKienTaiKhoan_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.LoaiSanPham_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.Class.QuanBan_Class;
import com.example.doandd_datdoan.Class.SuKienTaiKhoan_Class;
import com.example.doandd_datdoan.Fragment.DonHangCu_Frament;
import com.example.doandd_datdoan.Fragment.KhuyenMai_Frament;
import com.example.doandd_datdoan.Fragment.ListSanPham_Fragment;
import com.example.doandd_datdoan.R;
import com.google.android.material.navigation.NavigationView;


import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class TrangChinh extends AppCompatActivity {
    Toolbar toolbar;
    DrawerLayout drawerLayout;
    NavigationView navigationView;
    ViewFlipper viewFlipper;
    Connection conn;
    FrameLayout layouthoast;

    ArrayList<LoaiSanPham_Class> dulieuMA = new ArrayList<>();
    LoaiSanPham_Adpater loaiSanPham_adpater;
    RecyclerView rc_LoaiMA;

    ArrayList<QuanBan_Class> duLieuQA = new ArrayList<>();
    QuanBan_Adpater quanBan_adpater;
    RecyclerView rc_QuanAn, rc_QuanDaDatMon;

    ArrayList<QuanBan_Class> duLieuQADaDat = new ArrayList<>();

    TextView txt_TenKH, txt_Email, txt_DiaChiKH;
    CircleImageView img_anhKH;
    ListView lv;
    ArrayList<SuKienTaiKhoan_Class> suKienTaiKhoan_classes = new ArrayList<>();
    SuKienTaiKhoan_Adpater suKienTaiKhoan_adpater;
    String maKH, maCH;
    Button bn_TimKiem;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_trangchu);

        toolbar = findViewById(R.id.toolbar);
        drawerLayout = findViewById(R.id.drawerlayout);
        navigationView = findViewById(R.id.navigationview);
        viewFlipper = findViewById(R.id.viewfilpper);
        layouthoast = findViewById(R.id.fl_sanPham);
        rc_LoaiMA = findViewById(R.id.rc_loaisanpham);
        txt_TenKH = findViewById(R.id.txt_TenKH);
        txt_Email = findViewById(R.id.txt_EmailKH);
        img_anhKH = findViewById(R.id.img_anhKH);
        txt_DiaChiKH = findViewById(R.id.txt_DiaChiKH);
        lv = findViewById(R.id.lv_item);
        rc_QuanAn = findViewById(R.id.rc_quanBan);
        rc_QuanDaDatMon = findViewById(R.id.rc_DanhSachDaDat);
        bn_TimKiem = findViewById(R.id.bn_TimKiem);

        bn_TimKiem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(TrangChinh.this, TimKiem_Activity.class);
                startActivity(intent);
            }
        });

        String [] s= {"Đơn hàng của tôi", "Nhà hàng yêu thích", "Quản lí thanh toán", "Ví Coupon", "Địa chỉ đã lưu", "Hỗ trợ"};
        for (int i = 0;i < s.length ;i++)
        {
            suKienTaiKhoan_classes.add(new SuKienTaiKhoan_Class(s[i]));
        }
        suKienTaiKhoan_adpater = new SuKienTaiKhoan_Adpater(getBaseContext(), suKienTaiKhoan_classes);
        lv.setAdapter(suKienTaiKhoan_adpater);
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                SuKienTaiKhoan_Class suKienTaiKhoan_class2 = (SuKienTaiKhoan_Class) suKienTaiKhoan_adpater.getItem(position);
                if(suKienTaiKhoan_class2.getSuKien().equals("Đơn hàng của tôi"))
                {
                   /* Intent intent = new Intent(TrangChinh.this, DonHangCu_Activity.class);
                    intent.putExtra("maKH", maKH);
                    startActivity(intent);*/
                    Intent intent = new Intent(TrangChinh.this, SuKienTaiKhoan_Activity.class);
                    intent.putExtra("giaTri", "1");
                    intent.putExtra("maKH", maKH);
                    intent.putExtra("tenTieuDe", "Đơn hàng của tôi");
                    startActivity(intent);
                }
                else if(suKienTaiKhoan_class2.getSuKien().equals("Ví Coupon"))
                {
                    Intent intent = new Intent(TrangChinh.this, SuKienTaiKhoan_Activity.class);
                    intent.putExtra("giaTri", "2");
                    intent.putExtra("tenTieuDe", "Ví Coupon");
                    startActivity(intent);
                }
                else if(suKienTaiKhoan_class2.getSuKien().equals("Địa chỉ đã lưu"))
                {
                    Intent intent = new Intent(TrangChinh.this, SuKienTaiKhoan_Activity.class);
                    intent.putExtra("giaTri", "3");
                    intent.putExtra("maKH", maKH);
                    intent.putExtra("tenTieuDe", "Địa chỉ đã lưu");
                    startActivity(intent);
                }
            }
        });

        Intent intent = getIntent();
        txt_TenKH.setText(intent.getStringExtra("tenKH"));
        txt_TenKH.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(TrangChinh.this, ThongTinKHang_Activity.class);
                intent.putExtra("maKH", maKH);
                startActivity(intent);
            }
        });
        txt_Email.setText(intent.getStringExtra("emailKH"));
       txt_DiaChiKH.setText(intent.getStringExtra("diaChiKH"));
        maKH =  intent.getStringExtra("maKH");

        img_anhKH.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(getBaseContext(), intent.getStringExtra("anhKH")));

        LoadFragment(new ListSanPham_Fragment());
        //Cấu hình toolbar
        setSupportActionBar(toolbar);
        getSupportActionBar().setTitle(0);
        getSupportActionBar().setDisplayHomeAsUpEnabled(true);
        getSupportActionBar().setDisplayShowHomeEnabled(true);
        toolbar.setNavigationIcon(R.drawable.chuyenthongtin);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                drawerLayout.openDrawer(GravityCompat.START);
            }
        });

        loaiSanPham_adpater = new LoaiSanPham_Adpater(dulieuMA, this);
        loadLoaiSanPham();
        rc_LoaiMA.setAdapter(loaiSanPham_adpater);
        GridLayoutManager gridLayoutManager = new GridLayoutManager(this, 4);
        gridLayoutManager.setOrientation(GridLayoutManager.VERTICAL);
        rc_LoaiMA.setLayoutManager(gridLayoutManager);
        loaiSanPham_adpater.setOnItemClickedListener(new LoaiSanPham_Adpater.OnItemClickedListener() {
            @Override
            public void onItemClick(String username) {
               // Toast.makeText(TrangChinh.this, username, Toast.LENGTH_SHORT).show();
                Intent intent = new Intent(TrangChinh.this, SuKienTaiKhoan_Activity.class);
                intent.putExtra("maLoai", username);
                intent.putExtra("giaTri", "4");
                intent.putExtra("tenTieuDe", "Loại món ăn");
                startActivity(intent);

            }
        });

        quanBan_adpater = new QuanBan_Adpater(duLieuQA, this);
        LoadQuanAn();
        rc_QuanAn.setAdapter(quanBan_adpater);
        rc_QuanAn.setLayoutManager(new LinearLayoutManager( this, LinearLayoutManager.HORIZONTAL, false));
        quanBan_adpater.setOnItemClickedListener(new QuanBan_Adpater.OnItemClickedListener() {
            @Override
            public void onItemClick(String username) {
            //    Toast.makeText(TrangChinh.this, username, Toast.LENGTH_SHORT).show();
               Intent intent = new Intent(TrangChinh.this, CTCuaHang_Activity.class);
                intent.putExtra("maCH", username);
                intent.putExtra("maKH", maKH);
                startActivity(intent);
            }
        });

        quanBan_adpater = new QuanBan_Adpater(duLieuQADaDat, this);
        LoadNhungQuanTungDat(maKH);
        rc_QuanDaDatMon.setAdapter(quanBan_adpater);
        rc_QuanDaDatMon.setLayoutManager(new LinearLayoutManager( this, LinearLayoutManager.HORIZONTAL, false));
        quanBan_adpater.setOnItemClickedListener(new QuanBan_Adpater.OnItemClickedListener() {
            @Override
            public void onItemClick(String username) {
                //    Toast.makeText(TrangChinh.this, username, Toast.LENGTH_SHORT).show();
                Intent intent = new Intent(TrangChinh.this, CTCuaHang_Activity.class);
                intent.putExtra("maKH", maKH);
                intent.putExtra("maCH", username);
                startActivity(intent);
            }
        });


        LoadViewFilpper();
    }
    private void LoadViewFilpper() {

        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                ArrayList<String> manfsile = new ArrayList<>();
                String read = "select HinhAnhKM from KHUYENMAI";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String hinhSP = rs.getString("HinhAnhKM");
                    manfsile.add(hinhSP);
                }
                for (int i = 0; i < manfsile.size(); i ++)
                {
                    ImageView img = new ImageView(this);
                    img.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(getBaseContext(), manfsile.get(i)));
                    viewFlipper.addView(img);
                }
                viewFlipper.setAutoStart(true);
                viewFlipper.setFlipInterval(2000);
                viewFlipper.startFlipping();
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
    public void LoadFragment(Fragment fragment) {
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        transaction.replace(R.id.fl_sanPham, fragment);
        transaction.commit();
    }
    public void loadLoaiSanPham() {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select * from LOAIMON";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                int i =0;
                while (rs.next()) {
                    i++;
                    String tenloai = rs.getString("TenLoaiMon");
                    String hinhanhLoai ="HinhLoaiSP"+i+".png";
                    String maLoai = rs.getString("MaLoaiMon");
                    dulieuMA.add(new LoaiSanPham_Class(tenloai, hinhanhLoai, maLoai));
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
    public void LoadQuanAn() {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if (conn != null) {
                String read = "select *from CUAHANGMON";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenQA = rs.getString("TenCuaHang");
                    String danhGia = rs.getString("DanhGia");
                    String hinhAnhQA = rs.getString("HinhAnhCH");
                    maCH = rs.getString("MaCuaHangMon");
                    duLieuQA.add(new QuanBan_Class(tenQA, "15 phút", "5 km", danhGia, hinhAnhQA, maCH));
                }
            }
            else {
            }
        } catch (Exception ex) {
            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
    }
    public  String loadDiaChi(String maKH)
    {
        String diaChi ="";
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if (conn != null) {
                String read = "select DiaChi from KHACHHANG where MaKH = '"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                     diaChi = rs.getString("DiaChi");
                   return  diaChi;
                }
            }
            else {
            }
        } catch (Exception ex) {
            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
        return diaChi;
    }
    public  void LoadNhungQuanTungDat(String maKH) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if (conn != null) {
                String read = "select DISTINCT TenCuaHang, HinhAnhCH, DanhGia, CUAHANGMON.MaCuaHangMon from CUAHANGMON, DONHANG where CUAHANGMON.MaCuaHangMon = DONHANG.MaCuaHangMon and MaKH = '"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenQA = rs.getString("TenCuaHang");
                    String danhGia = rs.getString("DanhGia");
                    String hinhAnhQA = rs.getString("HinhAnhCH");
                    maCH = rs.getString("MaCuaHangMon");
                    duLieuQADaDat.add(new QuanBan_Class(tenQA, "15 phút", "5 km", danhGia, hinhAnhQA, maCH));
                }
            }
            else {
            }
        } catch (Exception ex) {
            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
    }

}