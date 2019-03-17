# ADETGS 4 (2019) Voting System

Aplikasi simpel untuk membantu pengunjung memilih stand favorit di event ADETGS.

## Sebelum Memulai

Instruksi ini akan membantu anda dalam menggunakan applikasi stand-alone ini. Perhatikan lebih lanjut untuk langkah-langkah berikutnya.

### Kebutuhan

Sebelum menggunakan applikasi stand-alone ini, pastikan sudah tersedia:

```
Visual Studio (2010, 2013)
NET. Framework 4.5 (atau versi terbaru)
Notepad++
```

### Screen Resolution

Pastikan dengan sangat bahwa aplikasi ini tidak men-support resolusi selain:

```
1920 x 1080 (HD 1080); STABLE
1366 x 768 (HD 768); UNSTABLE! (kemungkinan crash atau error)
```

### Installing

Untuk menginstall aplikasi ini, pastikan sudah menyiapkan folder tersendiri di harddrive 'D:\' atau lainnya ('E:\', 'F:\', dsb) , terkecuali 'C:\', karena akan membutuhkan Admin Permission untuk menjalankan aplikasi Voting System.

Rekomendasi untuk menyimpan di:
```
D:\ADETGSX\aplikasiX.exe
```

## Menjalankan Aplikasi

Pertama kali membuka aplikasi hal yang harus dilakukan adalah:
```
1. Klik tombol pengaturan di bagian kanan bawah.
2. Isi 'Lokasi Penyimpanan' dengan direktori dimana nanti aplikasi akan mengeluarkan laporan hasil voting. Gunakan tombol browse untuk mempermudah.
3. Isi 'Nama Report' dengan nama laporan hasil voting.
4. OPSIONAL: Isi TextBox 'IP Address' dan 'Port' dengan konfigurasi ADETGS4 MASTER VOTING.
5. Klik tombol Update di semua TextBox (Lokasi, Nama, dan Opsional: IP Address dan Port)
6. Tekan Exit Form.
```
Perlu diketahui bahwa data pengaturan akan ter-RESET setiap aplikasi tertutup dan dibuka kembali, data TextBox tidak tersimpan dimanapun, jadi konfigurasi pengaturan tidak bisa dimuat.

Menggunakan aplikasi voting ADETGS 4 (2019):
```
1. Klik tombol Mulai Voting.
2. Ikuti hingga langkah selanjutnya.
3. Gunakan tombol kiri dan kanan untuk memilih stand favorit.
4. Klik Vote.
5. Tinggalkan jika pesan sudah berbunyi sukses.
```

### Output Hasil Lokal

Dari voting yang sudah dilakukan, hasil tersebut akan dikeluarkan ke file dalam bentuk '.txt', file tersebut berada pada direktori yang sudah diatur diawal membuka aplikasi. Jika kebingungan mencari dapat membukanya lewat:
```
Pengaturan > Open File.
```

### Output Hasil LAN

Terdapat fitur opsional yaitu, fitur LAN untuk mengkomunikasi-kan dengan PC lain. Fitur LAN ini dapat digunakan dengan aplikasi tambahan yaitu ADETGS 4 MASTER VOTING. 

Dari IP dan Port yang sudah diatur dalam Tab Pengaturan, software MASTER VOTING dapat melihat dan menggabungkan sendiri jumlah vote per-stand dari komputer / laptop yang sudah terkoneksi jaringannya.

## Debug / Error / Crash

Kemunkinan error yang sering terjadi resolusi aplikasi tidak sesuai dengan ukuran layar. Pastikan resolusi layar sesuai:
```
1. Pastikan kursor berada di Desktop.
2. Klik kanan, buka Screen Resolution atau Display Settings.
3. Pastikan sudah menggunakan resolusi yang sesuai tertera di atas.
```

Bila aplikasi masih tetap berjalan tidak sesuai ukuran layar, ubah pembesaran layar Windows:
```
1. Pastikan kursor berada di Desktop.
2. Klik kanan, buka Screen Resolution atau Display Settings.
3. Pastikan Scale and Layout menggunakan opsi 100%.
```

## Dibuat Dengan

* [Visual Studio Community 2017](https://visualstudio.microsoft.com/vs/community/) - App Desinger
* [NET. Framework 4.5](https://www.microsoft.com/en-us/download/details.aspx?id=30653) - FrameWork Components

Serta sepenuh hati, dari tim ADETGS 4 (2019).
