package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Paint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.doandd_datdoan.Adpater.ApDungKhuyenMai_Adpater;
import com.example.doandd_datdoan.Adpater.CTDonHang_Adpater;
import com.example.doandd_datdoan.Adpater.QuanBan_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.KhuyenMai_Class;
import com.example.doandd_datdoan.Class.LoaiSanPham_Class;
import com.example.doandd_datdoan.Fragment.KhuyenMai_Frament;
import com.example.doandd_datdoan.R;

import net.sourceforge.jtds.jdbc.DateTime;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;

public class DatMon_Activity extends AppCompatActivity {
    ListView lv_DatMon;
    CTDonHang_Adpater ctDonHangAdpater;
    TextView txt_TongTien, txt_ThanhTien, txt_TienShip, txt_TenKH, txt_DiaChi, txt_tenCuaHangMon, txt_ApDungKM, txt_TienGiaKM;
    String maKH, maCH, maKhuyenMai = "NULL";
    Connection conn;
    Button bn_quaylai,  bn_DatMon;
    int thanhtien = 0;
    int tiShip;
    TextView bn_ChinhSuaDC ;
    int thanhtoan;
    RecyclerView rc_KhuyenMai;
    ArrayList<KhuyenMai_Class> khuyenMai_classes = new ArrayList<>();
    ApDungKhuyenMai_Adpater khuyenMaiAdpater;
    TextView tv2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_datmonan);

        lv_DatMon = findViewById(R.id.lv_CtDatMon);
        txt_TongTien = findViewById(R.id.txt_TongTien);
        txt_ThanhTien = findViewById(R.id.txt_ThanhTienDatMon);
        txt_TienShip = findViewById(R.id.txt_TienGiaoHang);
        txt_TenKH = findViewById(R.id.txt_TenKHDatMon);
        txt_DiaChi = findViewById(R.id.txt_DiaChiKHDatMon);
        txt_tenCuaHangMon = findViewById(R.id.txt_TenCuaHangDatMon);
        bn_quaylai = findViewById(R.id.bn_quaylai6);
        bn_DatMon = findViewById(R.id.bn_DatMon);
        bn_ChinhSuaDC = findViewById(R.id.bn_ChinhSuaDC);
        txt_ApDungKM = findViewById(R.id.txt_ApDungKM);
        rc_KhuyenMai = findViewById(R.id.rc_KhuyenMai);
        txt_TienGiaKM = findViewById(R.id.txt_TienGiaKM);
        khuyenMaiAdpater = new ApDungKhuyenMai_Adpater(khuyenMai_classes, this);
        LoadKhuyenMai();
        rc_KhuyenMai.setAdapter(khuyenMaiAdpater);
        rc_KhuyenMai.setLayoutManager(new LinearLayoutManager( this, LinearLayoutManager.HORIZONTAL, false));
        khuyenMaiAdpater.setOnItemClickedListener(new ApDungKhuyenMai_Adpater.OnItemClickedListener() {
            @Override
            public void onItemClick(String username) {
               // String maKM = username;
               // Toast.makeText(DatMon_Activity.this, username, Toast.LENGTH_SHORT).show();
                maKhuyenMai = LoadTheoMaKhuyenMai(username, thanhtien+"000.0000");
                thanhtoan = thanhtien + tiShip ;
                if(maKhuyenMai.equals("NULL") || maKhuyenMai.equals(""))
                {
                    maKhuyenMai = "NULL";
                    showAlertDialog("Mã giảm giá không giành cho đơn hàng của bạn hãy mua thêm");
                    txt_ApDungKM.setText("Ưu đãi");
                    txt_ThanhTien.setText(thanhtoan+".000 VNĐ");
                    txt_TienGiaKM.setText("");
                }
                else {
                    txt_ApDungKM.setText(maKhuyenMai);
                    Double giaDuocGiam = LoadGiaDuocGiam(maKhuyenMai);
                    Double tongtien = Double.parseDouble(thanhtoan+"000.0");
                    Double tienduocGiam = tongtien - giaDuocGiam;
                    int tienChiTra = (tienduocGiam.intValue())/1000;
                    txt_ThanhTien.setText(tienChiTra +".000 VNĐ");
                    txt_TienGiaKM.setText("Giá cũ: "+thanhtoan+".000 VNĐ");
                    txt_TienGiaKM.setPaintFlags(txt_TienGiaKM.getPaintFlags() | Paint.STRIKE_THRU_TEXT_FLAG);
                }
            }
        });

        bn_ChinhSuaDC.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                    Intent intent = new Intent(DatMon_Activity.this, SuKienTaiKhoan_Activity.class);
                    intent.putExtra("giaTri", "3");
                    intent.putExtra("maKH", maKH);
                    intent.putExtra("tenTieuDe", "Địa chỉ đã lưu");
                    startActivity(intent);
            }
        });
        bn_DatMon.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(CTCuaHang_Activity.ctDonHangClasses.size() != 0) {
                    long millis=System.currentTimeMillis();
                    java.sql.Date date =new java.sql.Date(millis);
                    String maDHang = "DH0" + layMaDonHang();
                    thanhtoan = thanhtien + tiShip ;
                    if(maKhuyenMai.equals("NULL"))
                    {

                        if (themDonHangKKM(maDHang, maKH, maCH.trim(), date.toString(), txt_DiaChi.getText().toString(), "Tiền mặt", tiShip + "000", thanhtien + "000", thanhtoan+"000")) {
                            for (int i = 0; i < CTCuaHang_Activity.ctDonHangClasses.size(); i++) {
                                Double gia1Mon = Double.parseDouble(CTCuaHang_Activity.ctDonHangClasses.get(i).getGiaMon());
                                int gia1Mon2 = gia1Mon.intValue();
                                int soLuong = Integer.parseInt(CTCuaHang_Activity.ctDonHangClasses.get(i).getStt());
                                int giaMon = gia1Mon2 / soLuong;
                                themCTDonHang(maDHang, CTCuaHang_Activity.ctDonHangClasses.get(i).getMaMon().trim(), giaMon + "000", CTCuaHang_Activity.ctDonHangClasses.get(i).getGiaMon() + "000", CTCuaHang_Activity.ctDonHangClasses.get(i).getStt());
                            }
                            showAlertDialog("Đơn hàng đặt thành công");
                        }
                    }
                    else {
                        Double giaDuocGiam = LoadGiaDuocGiam(maKhuyenMai);
                        Double tongtien = Double.parseDouble(thanhtoan+"000.0");
                        Double tienduocGiam = tongtien - giaDuocGiam;
                        int tienChiTra = (tienduocGiam.intValue())/1000;
                        if (themDonHangTonTaiKM(maDHang, maKH, maCH.trim(), date.toString(), txt_DiaChi.getText().toString(), "Tiền mặt", tiShip + "000", thanhtien + "000", tienChiTra+"000", maKhuyenMai)) {
                            for (int i = 0; i < CTCuaHang_Activity.ctDonHangClasses.size(); i++) {
                                Double gia1Mon = Double.parseDouble(CTCuaHang_Activity.ctDonHangClasses.get(i).getGiaMon());
                                int gia1Mon2 = gia1Mon.intValue();
                                int soLuong = Integer.parseInt(CTCuaHang_Activity.ctDonHangClasses.get(i).getStt());
                                int giaMon = gia1Mon2 / soLuong;
                                themCTDonHang(maDHang, CTCuaHang_Activity.ctDonHangClasses.get(i).getMaMon().trim(), giaMon + "000", CTCuaHang_Activity.ctDonHangClasses.get(i).getGiaMon() + "000", CTCuaHang_Activity.ctDonHangClasses.get(i).getStt());
                            }
                            showAlertDialog("Đơn hàng đặt thành công");
                        }
                    }
                }
            }
        });
        bn_quaylai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                finish();
            }
        });
        Intent intent = getIntent();
        String tien = intent.getStringExtra("tongtien");
        String tienShip = txt_TienShip.getText().toString();
        maCH = intent.getStringExtra("maCH");
        maKH = intent.getStringExtra("maKH");
        loadKH(maKH);
        loadCuaHang(maCH);
        Double tShip = Double.parseDouble(tienShip);
         tiShip = tShip.intValue();
        txt_TongTien.setText(intent.getStringExtra("tongtien"));
        Double tt = Double.parseDouble(tien);
        thanhtien = tt.intValue();
        txt_ThanhTien.setText((thanhtien+ tiShip)+".000 VNĐ");
        ctDonHangAdpater = new CTDonHang_Adpater(CTCuaHang_Activity.ctDonHangClasses, getBaseContext());
        lv_DatMon.setAdapter(ctDonHangAdpater);
        lv_DatMon.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                finish();
            }
        });

    }
    private int layMaDonHang()
    {
        int i = 0;
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String sql = "select  Max(convert(int,SUBSTRING(MaDonHang,3,3))) as MaDonHang from DONHANG";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(sql);
                while (rs.next()) {
                    i = Integer.parseInt(rs.getString("MaDonHang"));
                }
                i++;
                return  i;
            }

        }
        catch (Exception ex)
        {

        }
        return  i;
    }
    private boolean themDonHangTonTaiKM(String maDonHang, String maKhachHang, String maCuaHang, String ngaydatHang, String diachigh, String hinhThuc, String giaShip, String TongTien, String thanhTien, String mKhuyenmai)
    {
        try {
            String sql = String.format("INSERT INTO DONHANG(MaDonHang, MaKH, MaCuaHangMon, NgayDat, DiaChiGiaoHang, HinhThucThanhToan, GiaShip, TongTien, ThanhToan, TinhTrang, MaKhuyenMai) "
                    + " VALUES('"+maDonHang+"', '"+maKhachHang+"','"+maCuaHang+"','"+ngaydatHang+"', N'"+diachigh+"' , N'"+hinhThuc+"' , '"+giaShip+"', '"+TongTien+"', '"+thanhTien+"', N'Đang xác nhận', '"+mKhuyenmai+"')");
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
    private boolean themDonHangKKM(String maDonHang, String maKhachHang, String maCuaHang, String ngaydatHang, String diachigh, String hinhThuc, String giaShip, String TongTien, String thanhTien)
    {
        try {
            String sql = String.format("INSERT INTO DONHANG(MaDonHang, MaKH, MaCuaHangMon, NgayDat, DiaChiGiaoHang, HinhThucThanhToan, GiaShip, TongTien, ThanhToan, TinhTrang) "
                    + " VALUES('"+maDonHang+"', '"+maKhachHang+"','"+maCuaHang+"','"+ngaydatHang+"', N'"+diachigh+"' , N'"+hinhThuc+"' , '"+giaShip+"', '"+TongTien+"', '"+thanhTien+"', N'Đang xác nhận')");
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
    private void themCTDonHang(String maDonHang, String maMon, String DonGia, String thanhTien, String SoLuong)
    {
        try {
            String sql = String.format("INSERT INTO CHITIETDONHANG(MaDonHang, MaMon, DonGia,ThanhTien, SoLuong) "
                    + " VALUES('"+maDonHang+"', '"+maMon+"','"+DonGia+"','"+thanhTien+"', '"+SoLuong+"')");
            KetNoiCSDL con = new KetNoiCSDL();
            conn = con.KetNoiCSDL();
            if(conn!= null) {
                Statement st = conn.createStatement();
                int i = st.executeUpdate(sql);
                if (i >= 1) {
                }
            }

        }
        catch (Exception ex)
        {

        }
    }
    public void loadKH(String maKH) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select * from KHACHHANG where MaKH = '"+maKH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenKH = rs.getString("TenKH");
                    String diaChi = rs.getString("DiaChi");
                    txt_TenKH.setText(tenKH);
                    txt_DiaChi.setText(diaChi);
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
    public void loadCuaHang(String maCH) {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select * from CUAHANGMON where MaCuaHangMon = '"+maCH+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenCH = rs.getString("TenCuaHang");
                   txt_tenCuaHangMon.setText(tenCH);
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
    public  void LoadKhuyenMai()
    {
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHUYENMAI where NgayBDKhuyenMai < GETDATE() and NgayKTKhuyenMai > GETDATE()";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenKM = rs.getString("TenKhuyenMai");
                    String ngayKTKM = rs.getString("NgayKTKhuyenMai");
                    String hinhAnhKM = rs.getString("HinhAnhKM");
                    khuyenMai_classes.add(new KhuyenMai_Class(hinhAnhKM, tenKM,"HSD: " +ngayKTKM));
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {

        }
    }
    public  String LoadTheoMaKhuyenMai(String MaKM, String dkKhuyenMai)
    {
       String maKM ="";
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHUYENMAI where TenKhuyenMai = N'"+MaKM+"' and DKKhuyenMai <= "+dkKhuyenMai+"";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    maKM =  rs.getString("MaKhuyenMai");
                    return maKM;
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {

        }
        return maKM;
    }
    public  double LoadGiaDuocGiam(String MaKM)
    {
        Double phanTram = 0.0;
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if(conn != null) {
                String read = "select *from KHUYENMAI where MaKhuyenMai = '"+MaKM+"'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    phanTram = Double.parseDouble(rs.getString("PhanTram")) ;
                    return phanTram;
                }
            }
            else
            {
            }
        }
        catch (Exception ex)
        {

        }
        return phanTram;
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