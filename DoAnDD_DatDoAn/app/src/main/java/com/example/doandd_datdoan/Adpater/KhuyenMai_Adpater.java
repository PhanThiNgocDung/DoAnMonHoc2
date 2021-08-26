package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;
import com.example.doandd_datdoan.Class.KhuyenMai_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class KhuyenMai_Adpater extends BaseAdapter {
    Context context;
    ArrayList<KhuyenMai_Class> khuyenMai_classes;

    public KhuyenMai_Adpater(Context context, ArrayList<KhuyenMai_Class> khuyenMai_classes) {
        this.context = context;
        this.khuyenMai_classes = khuyenMai_classes;
    }

    @Override
    public int getCount() {
        return khuyenMai_classes.size();
    }

    @Override
    public Object getItem(int position) {
        return khuyenMai_classes.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_khuyenmai, null);

        TextView txt_TenKM = convertView.findViewById(R.id.txt_tenKM);
        TextView txt_HSDKM = convertView.findViewById(R.id.txt_ngayGGKM);
        CircleImageView hinhAnhKM =convertView.findViewById(R.id.img_hinhAnhKM);

       KhuyenMai_Class ql = khuyenMai_classes.get(position);

        txt_TenKM.setText(ql.getTenKM());
        txt_HSDKM.setText(ql.getHSDKM());
        hinhAnhKM.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context,ql.getHinhAnhKM()));
        return convertView;
    }
}
