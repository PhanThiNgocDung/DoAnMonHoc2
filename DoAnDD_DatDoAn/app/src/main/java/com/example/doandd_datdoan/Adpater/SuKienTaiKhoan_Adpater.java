package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.Class.SuKienTaiKhoan_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class SuKienTaiKhoan_Adpater extends BaseAdapter {
    Context context;
    ArrayList<SuKienTaiKhoan_Class> suKienTaiKhoan_classes;

    public SuKienTaiKhoan_Adpater(Context context, ArrayList<SuKienTaiKhoan_Class> suKienTaiKhoan_classes) {
        this.context = context;
        this.suKienTaiKhoan_classes = suKienTaiKhoan_classes;
    }

    @Override
    public int getCount() {
        return suKienTaiKhoan_classes.size();
    }

    @Override
    public Object getItem(int position) {
        return suKienTaiKhoan_classes.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_sukientaikhoan, null);
       TextView tenSuKien =  convertView.findViewById(R.id.txt_tenSuKien);
        SuKienTaiKhoan_Class ql = suKienTaiKhoan_classes.get(position);
        tenSuKien.setText(ql.getSuKien());
        return convertView;
    }
}
