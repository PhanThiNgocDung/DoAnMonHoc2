package com.example.doandd_datdoan.Activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.drawerlayout.widget.DrawerLayout;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SearchView;
import android.widget.Toast;

import com.example.doandd_datdoan.Adpater.MonAn_Adpater;
import com.example.doandd_datdoan.Class.KetNoiCSDL;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.Class.QuanBan_Class;
import com.example.doandd_datdoan.R;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

import me.gujun.android.taggroup.TagGroup;

public class TimKiem_Activity extends AppCompatActivity {
    TagGroup mTagGroup;
    SearchView searchView;
    Toolbar toolbar;
    Connection conn;
    ArrayList<MonAn_Class> monAn_classes = new ArrayList<>();
    MonAn_Adpater monAn_adpater;
    ListView lv_Tim;
    Button bn_quayLai;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_seach);
        toolbar = findViewById(R.id.Toolbar);
        lv_Tim = findViewById(R.id.lv_TimKiem);
        searchView = findViewById(R.id.search_view);
        bn_quayLai = findViewById(R.id.bn_QuayLai);

        bn_quayLai.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent=new Intent(TimKiem_Activity.this, TrangChinh.class);
                finish();
            }
        });
        searchView.setIconifiedByDefault(true);
        searchView.setFocusable(true);
        searchView.setIconified(false);
        searchView.requestFocusFromTouch();
        searchView.setOnQueryTextListener(new SearchView.OnQueryTextListener() {
            @Override
            public boolean onQueryTextSubmit(String query) {

                return false;
            }

            @Override
            public boolean onQueryTextChange(String newText) {
                monAn_classes.clear();
                LoadMonAnTK(newText);
                monAn_adpater = new MonAn_Adpater(getBaseContext(), monAn_classes);
                lv_Tim.setAdapter(monAn_adpater);
                return false;
            }
        });
        mTagGroup = findViewById(R.id.tag_group);
        mTagGroup.setTags(new String[]{"Cơm gà", "Bún bò", "Bánh mì", "Mì cay", "Bánh tráng", "Cháo", "Bún thịt nướng", "Hủ tiếu", "Gỏi cuốn", "Chè", "Sinh tố", "Pizza"});
        mTagGroup.setOnTagClickListener(new TagGroup.OnTagClickListener() {
            @Override
            public void onTagClick(String tag) {
                searchView.setQuery(tag, false);
            }
        });
        LoadMonAnTK("");
        monAn_adpater = new MonAn_Adpater(getBaseContext(), monAn_classes);
        lv_Tim.setAdapter(monAn_adpater);
    }
    public  void LoadMonAnTK(String timKiem){
        try {
            KetNoiCSDL kn = new KetNoiCSDL();
            conn = kn.KetNoiCSDL();
            if (conn != null) {
                String read = "select DISTINCT TenMon, HinhAnhMon, DanhGia from MONAN, CUAHANGMON where MONAN.MaCuaHangMon = CUAHANGMON.MaCuaHangMon and TenMon like N'%"+timKiem+"%'";
                Statement st = conn.createStatement();
                ResultSet rs = st.executeQuery(read);
                while (rs.next()) {
                    String tenSP = rs.getString("TenMon");
                    String hinhSP = rs.getString("HinhAnhMon");
                    String soSao = rs.getString("DanhGia");
                    monAn_classes.add(new MonAn_Class(tenSP, hinhSP, soSao, "5km"));
                }
            }
            else {
                   monAn_classes.clear();
            }
        } catch (Exception ex) {
            Toast.makeText(getApplicationContext(), "Vui lòng kiểm tra kết nối mạng", Toast.LENGTH_LONG).show();
        }
    }
}