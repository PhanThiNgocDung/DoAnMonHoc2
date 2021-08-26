package com.example.doandd_datdoan.Adpater;

import android.app.AlertDialog;
import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.example.doandd_datdoan.Activity.MainActivity;
import com.example.doandd_datdoan.Activity.TrangChinh;
import com.example.doandd_datdoan.Class.LoaiSanPham_Class;
import com.example.doandd_datdoan.Class.MonAn_Class;
import com.example.doandd_datdoan.R;
import com.squareup.picasso.Picasso;

import java.util.ArrayList;

import de.hdodenhof.circleimageview.CircleImageView;

public class LoaiSanPham_Adpater extends RecyclerView.Adapter<LoaiSanPham_Adpater.KHUNGHINH>{
    ArrayList<LoaiSanPham_Class> loaiSanPham_classes;
    Context context;

    public LoaiSanPham_Adpater(ArrayList<LoaiSanPham_Class> loaiSanPham_classes, Context context) {
        this.loaiSanPham_classes = loaiSanPham_classes;
        this.context = context;
    }

    @NonNull
    @Override
    public KHUNGHINH onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new KHUNGHINH(LayoutInflater.from(context).inflate(R.layout.layout_loaisp, null));
    }

    @Override
    public void onBindViewHolder(@NonNull KHUNGHINH holder, int position) {
        LoaiSanPham_Class lsp = loaiSanPham_classes.get(position);
        holder.tenLoai.setText(lsp.getTenLoaiSP());
        holder.maLoai = lsp.getMaLoaiM();
        holder.hinhanhloai.setImageBitmap(MonAn_Class.convertStringToBitmapFromAccess(context, lsp.getHinhAnhLoai()));
        //Hàm để xử lí để gọi
        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (onItemClickedListener != null) {
                    onItemClickedListener.onItemClick(holder.maLoai);
                }
               /* AlertDialog.Builder builder = new AlertDialog.Builder(context);
                builder.setTitle("Detail");
                String ma = loaiSanPham_classes.get(position).getTenLoaiSP();
                builder.setMessage(ma);
                AlertDialog alertDialog = builder.create();
                alertDialog.show();*/
            }
        });
    }

    @Override
    public int getItemCount() {
        return loaiSanPham_classes.size();
    }


    public class KHUNGHINH extends RecyclerView.ViewHolder{
        TextView tenLoai;
        CircleImageView hinhanhloai;
        String maLoai;
        public KHUNGHINH(@NonNull View itemView) {
            super(itemView);
            tenLoai = itemView.findViewById(R.id.txt_TenLoaiSP);
            hinhanhloai = itemView.findViewById(R.id.img_HinhLoaiSP);

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
