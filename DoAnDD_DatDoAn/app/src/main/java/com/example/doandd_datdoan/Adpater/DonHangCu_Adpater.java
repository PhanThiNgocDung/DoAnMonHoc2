package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.doandd_datdoan.Class.DonHangCu_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;


public class DonHangCu_Adpater extends BaseAdapter {
    Context context;
    ArrayList<DonHangCu_Class> donHangCu_classes;

    public DonHangCu_Adpater(Context context, ArrayList<DonHangCu_Class> donHangCu_classes) {
        this.context = context;
        this.donHangCu_classes = donHangCu_classes;
    }

    @Override
    public int getCount() {
        return donHangCu_classes.size();
    }

    @Override
    public Object getItem(int position) {
        return donHangCu_classes.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_donhangcu, null);

        TextView txt_TinhTrang = convertView.findViewById(R.id.txt_TinhTrangDHC);
        TextView txt_ThoiGianDH = convertView.findViewById(R.id.txt_ThơiGianDHC);
        TextView txt_TenQuan = convertView.findViewById(R.id.txt_TenQuanDHC);
        TextView txt_DiaChiQA = convertView.findViewById(R.id.txt_DiaChiQADHC);
        TextView txt_TongTien= convertView.findViewById(R.id.txt_TongTienDHC);
        TextView txt_hinhThuTT = convertView.findViewById(R.id.txt_HinhThucTTDHC);
        TextView txt_TongMon = convertView.findViewById(R.id.txt_TongMonDHC);

        DonHangCu_Class ql = donHangCu_classes.get(position);

        txt_TinhTrang.setText(ql.getTinhTrang());
        txt_ThoiGianDH.setText(ql.getThoiGian());
        txt_TenQuan.setText(ql.getTenQuan());
        txt_DiaChiQA.setText(ql.getDiaChi());
        txt_TongTien.setText(ql.getTongTien());
        txt_hinhThuTT.setText(ql.getHinhThucTT());
        txt_TongMon.setText(ql.getTongMon());
        return convertView;
    }
}
