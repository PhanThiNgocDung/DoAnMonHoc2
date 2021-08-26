package com.example.doandd_datdoan.Adpater;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.doandd_datdoan.Class.LoaiSanPham_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.Class.QuanBan_Class;
import com.example.doandd_datdoan.R;

import java.util.ArrayList;


public class QuanBan_Adpater  extends RecyclerView.Adapter<QuanBan_Adpater.KHUNGHINH>{
    ArrayList<QuanBan_Class> quanBan_classes;
    Context context;

    public QuanBan_Adpater(ArrayList<QuanBan_Class> quanBan_classes, Context context) {
        this.quanBan_classes = quanBan_classes;
        this.context = context;
    }

    @NonNull
    @Override
    public KHUNGHINH onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new QuanBan_Adpater.KHUNGHINH(LayoutInflater.from(context).inflate(R.layout.layout_quanban, null));
    }

    @Override
    public void onBindViewHolder(@NonNull KHUNGHINH holder, int position) {
        QuanBan_Class lsp = quanBan_classes.get(position);
        holder.tenQA.setText(lsp.getTenQuan());
        holder.maCH = lsp.getMaCH();
        holder.hinhAnhQN.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context, lsp.getHinhQN()));
        holder.thoiGianGH.setText(lsp.getThoiGianGao());
        holder.soSaoQA.setText(lsp.getSoSao());
        holder.soCayQA.setText(lsp.getSoCay());
        //Lay mã cửa hàng

        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (onItemClickedListener != null) {
                    onItemClickedListener.onItemClick(holder.maCH);
                }
            }
        });
    }

    @Override
    public int getItemCount() {
        return quanBan_classes.size();
    }


    public class KHUNGHINH extends RecyclerView.ViewHolder{
        TextView tenQA, soSaoQA, thoiGianGH, soCayQA;
        ImageView hinhAnhQN;
        String maCH;

        public KHUNGHINH(@NonNull View itemView) {
            super(itemView);
            tenQA = itemView.findViewById(R.id.txt_TenQA);
            hinhAnhQN = itemView.findViewById(R.id.img_hinhQA);
            soCayQA = itemView.findViewById(R.id.txt_soCayQA);
            soSaoQA =  itemView.findViewById(R.id.txt_soSaoQA);
            thoiGianGH =  itemView.findViewById(R.id.txt_ThoiGianGH);
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
