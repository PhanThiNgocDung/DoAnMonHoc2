package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.doandd_datdoan.Class.KhuyenMai_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;


public class ApDungKhuyenMai_Adpater extends RecyclerView.Adapter<ApDungKhuyenMai_Adpater.KHUNGHINH>{
    ArrayList<KhuyenMai_Class> khuyenMaiClassArrayAdapter;
    Context context;

    public ApDungKhuyenMai_Adpater(ArrayList<KhuyenMai_Class> khuyenMaiClassArrayAdapter, Context context) {
        this.khuyenMaiClassArrayAdapter = khuyenMaiClassArrayAdapter;
        this.context = context;
    }

    @NonNull
    @Override
    public KHUNGHINH onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new ApDungKhuyenMai_Adpater.KHUNGHINH(LayoutInflater.from(context).inflate(R.layout.layout_khuyenmai, null));
    }

    @Override
    public void onBindViewHolder(@NonNull KHUNGHINH holder, int position) {
        KhuyenMai_Class km = khuyenMaiClassArrayAdapter.get(position);
        holder.txt_TenKM.setText(km.getTenKM());
        holder.txt_HSDKM.setText(km.getHSDKM());
        holder.maKM = km.getTenKM();
        holder.hinhAnhKM.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context,km.getHinhAnhKM()));

        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (onItemClickedListener != null) {
                    onItemClickedListener.onItemClick(holder.maKM);
                }
            }
        });
    }

    @Override
    public int getItemCount() {
        return khuyenMaiClassArrayAdapter.size();
    }

    public class KHUNGHINH extends RecyclerView.ViewHolder{
        TextView txt_TenKM, txt_HSDKM;
         CircleImageView hinhAnhKM;
        String maKM;

        public KHUNGHINH(@NonNull View itemView) {
            super(itemView);
             txt_TenKM = itemView.findViewById(R.id.txt_tenKM);
             txt_HSDKM = itemView.findViewById(R.id.txt_ngayGGKM);
             hinhAnhKM = itemView.findViewById(R.id.img_hinhAnhKM);
        }
    }
    //Tạo hàm giả đê gọi
    public interface OnItemClickedListener {
        void onItemClick(String username);
    }
    private OnItemClickedListener onItemClickedListener;

    public void setOnItemClickedListener(OnItemClickedListener onItemClickedListener) {
        this.onItemClickedListener = onItemClickedListener;
    }
    //
}
