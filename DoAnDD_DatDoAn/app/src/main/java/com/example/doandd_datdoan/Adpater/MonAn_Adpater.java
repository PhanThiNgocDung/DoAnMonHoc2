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

public class MonAn_Adpater extends BaseAdapter {
    Context context;
    ArrayList<MonAn_Class> monAnArrayList;
    public MonAn_Adpater(Context context, ArrayList<MonAn_Class> monAnArrayList) {
        this.context = context;
        this.monAnArrayList = monAnArrayList;
    }

    @Override
    public int getCount() {
        return monAnArrayList.size();
    }


    @Override
    public Object getItem(int i) {
        return monAnArrayList.get(i);
    }

    @Override
    public long getItemId(int i) {
        return (long)i;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_listsanpham, null);
        CircleImageView img_hinhSanPham = convertView.findViewById(R.id.img_hinhSP);
        TextView txt_tenSanPham = convertView.findViewById(R.id.txt_tenSanPham);
        TextView txt_soSao = convertView.findViewById(R.id.txt_SoSao);
        TextView txt_soCay = convertView.findViewById(R.id.txt_soCay);
        MonAn_Class ql = monAnArrayList.get(position);
        img_hinhSanPham.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context, ql.getHinhSP()));
        txt_tenSanPham.setText(ql.getTenSP());
        txt_soCay.setText(ql.getSoCay());
        txt_soSao.setText(ql.getDanhGia());
        return convertView;
    }
}
