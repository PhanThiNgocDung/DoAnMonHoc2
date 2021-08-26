package com.example.doandd_datdoan.Activity;

import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

import androidx.core.app.NotificationCompat;
import androidx.core.app.NotificationManagerCompat;

import com.example.doandd_datdoan.R;

public class ReminderBroadcast extends BroadcastReceiver {
    @Override
    public void onReceive(Context context, Intent intent) {
        NotificationManager notificationManager =(NotificationManager) context.getSystemService(Context.NOTIFICATION_SERVICE);
        //Set su kien khi click vao thong bao. No se goi Intent Nay
        Intent repeating_intent = new Intent(context,MainActivity.class);
        repeating_intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);

        PendingIntent pendingIntent = PendingIntent.getActivities(context,100, new Intent[]{repeating_intent},PendingIntent.FLAG_UPDATE_CURRENT);

        NotificationCompat.Builder builder = new NotificationCompat.Builder(context,"notifyLemubit")
                .setSmallIcon(R.drawable.ic_baseline_circle_notifications_24)
                .setContentTitle("ORDER FOOD ƯU ĐÃI NGẬP TRÀN")
                .setContentText("Nhanh tay vào app để nhận ưu đãi mỗi ngày.Bạn đang phân vâng không biết nên ăn gì...Đừng lo đã có ORDER FOOD lo cho!")
                .setContentIntent(pendingIntent)
                .setAutoCancel(true);

        notificationManager.notify(100, builder.build());
    }
}
