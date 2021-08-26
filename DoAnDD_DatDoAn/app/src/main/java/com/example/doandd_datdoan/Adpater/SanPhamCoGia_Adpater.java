package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class SanPhamCoGia_Adpater extends BaseAdapter {
    Context context;
    ArrayList<MonAn_Class> monAnArrayList;

    public SanPhamCoGia_Adpater(Context context, ArrayList<MonAn_Class> monAnArrayList) {
        this.context = context;
        this.monAnArrayList = monAnArrayList;
    }

    @Override
    public int getCount() {
        return monAnArrayList.size();
    }

    @Override
    public Object getItem(int position) {
        return monAnArrayList.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_hienthimongia, null);
        CircleImageView img_hinhSanPham = convertView.findViewById(R.id.img_hinhSPMA);
        TextView txt_tenSanPham = convertView.findViewById(R.id.txt_tenSanPhamMA);
        TextView txt_soSao = convertView.findViewById(R.id.txt_SoSaoMA);
        TextView txt_soCay = convertView.findViewById(R.id.txt_soCayMA);
        TextView txt_Gia = convertView.findViewById(R.id.txt_giaMA);

        MonAn_Class ql = monAnArrayList.get(position);
        img_hinhSanPham.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context, ql.getHinhSP()));
        txt_tenSanPham.setText(ql.getTenSP());
        txt_soCay.setText(ql.getSoCay());
        txt_soSao.setText(ql.getDanhGia());
        txt_Gia.setText(ql.getGia());
        return convertView;
    }
}
