package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.doandd_datdoan.Class.CTDonHang_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class CTDonHang_Adpater extends BaseAdapter {
    ArrayList<CTDonHang_Class> ctDonHangClasses;
    Context context;

    public CTDonHang_Adpater(ArrayList<CTDonHang_Class> ctDonHangClasses, Context context) {
        this.ctDonHangClasses = ctDonHangClasses;
        this.context = context;
    }

    @Override
    public int getCount() {
        return ctDonHangClasses.size();
    }

    @Override
    public Object getItem(int position) {
        return ctDonHangClasses.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_ctdonhang, null);
        TextView txt_STT = convertView.findViewById(R.id.txt_SoTTCTDonHang);
        TextView txt_TenCTDonHang = convertView.findViewById(R.id.txt_TenCTDonHang);
        TextView txt_Gia = convertView.findViewById(R.id.txt_GiaCTDonHang);

        CTDonHang_Class ql = ctDonHangClasses.get(position);
        txt_STT.setText(ql.getStt());
        txt_TenCTDonHang.setText(ql.getTenMon());
        txt_Gia.setText(ql.getGiaMon());
        return convertView;
    }
}
