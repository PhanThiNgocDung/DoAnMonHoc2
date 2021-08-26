package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.doandd_datdoan.Class.DiaChiKH_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

public class DiaChiKH_Adpater extends BaseAdapter {
    Context context;
    ArrayList<DiaChiKH_Class> diaChiKH_classes;

    public DiaChiKH_Adpater(Context context, ArrayList<DiaChiKH_Class> diaChiKH_classes) {
        this.context = context;
        this.diaChiKH_classes = diaChiKH_classes;
    }

    @Override
    public int getCount() {
        return diaChiKH_classes.size();
    }

    @Override
    public Object getItem(int position) {
        return diaChiKH_classes.get(position);
    }

    @Override
    public long getItemId(int position) {
        return (long)position;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        if(convertView == null)
            convertView = LayoutInflater.from(context).inflate(R.layout.layout_diachikh, null);

        TextView txt_TenDiaChi = convertView.findViewById(R.id.txt_tenDiaChiDC);
        TextView txt_DiaChiDC = convertView.findViewById(R.id.txt_diachiKHCTDC);
        TextView txt_SoCayDC = convertView.findViewById(R.id.txt_soCayCuaMinhDC);

        DiaChiKH_Class ql = diaChiKH_classes.get(position);

        txt_TenDiaChi.setText(ql.getTenDiaChi());
        txt_DiaChiDC.setText(ql.getDiachiCT());
        txt_SoCayDC.setText(ql.getSoCayCMinh());
        return convertView;
    }
}
