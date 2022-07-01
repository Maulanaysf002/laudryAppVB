# laudryAppVB
desktop application for laundry management

alur program laundry :

- admin akan masuk ke halaman login dimana password dan username telah disediakan yaitu   (admin1)
- lalu admin akan masuk ke menu utama yang terdapat pilihan tombol untuk masuk ke menu :
   1. form penyerahan cucian :
      form ini berfungsi untuk menginputkan data pelanggan yang akan melakukan laundry pakaian. dalam form ini terdapat faktur, nama pelanggan, berat cucian,                   harga,panjar(uang muka), keterangan, sisa tagihan, dan estimasi selesai sebagai data yang harus dilengkapi untuk disimpan ke database.
   2. form data laundry :
      pada form ini akan menampilkan data laundry pelanggan yang masih diproses pencuciannya. Data dapat dicari dengan menggunakan nama atau faktur. pada form ini             terdapat tombol cetak laporan untuk mencetak data menggunakan crystal report.
   3. form pengembalian pakaian :
      form ini berisi data yang sama pada penyerahan cucian dimana ada tambahan status sebagai penanda bahwa pekerjaan laundry dari pelanggan sudah selesai. lalu data         akan dipindahkan dari data laundry ke list data laundry yang sudah selesai pada form ini.
      
- admin dapat keluar halaman dengan tombol close di menu utama.
program ini menggunakan :
- microsoft visual studio 2013
- crystal report for VS 13 SP 31
- mysql connector net 6.9.9
- .net framework 4.5.1
