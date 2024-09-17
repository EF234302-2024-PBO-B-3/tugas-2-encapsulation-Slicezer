[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/yidE2mOV)
# oop-encapsulation-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu menyembunyikan atau mengekspos atribut dengan mekanisme properti.
2. Mahasiswa mampu menggunakan access modifier public dan private sesuai kebutuhan. 
3. Mahasiswa mampu menjaga integritas objek dengan melakukan validasi pada properti maupun metode.

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-encapsulation-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Invoice

Buat solusi dari soal ini di project `Encapsulation` folder `Invoicing` dengan namespace `Encapsulation.Invoicing`.

Buatlah sebuah kelas publik yang bernama `Invoice` yang akan digunakan oleh toko untuk merepresentasikan faktur dari sebuah barang yang dijual di toko tersebut. Di kelas `Invoice` deklarasikan empat atribut private yaitu: `_partNumber` (tipe String), `_partDescription` (tipe String), `_quantity` (tipe int) dan `_price` (double). Sediakan empat properti publik yaitu: `PartNumber`, `PartDescription`, `Quantity` dan `Price` yang berisi metode set dan metode get untuk masing-masing atribut privat. Pastikan nilai yang dimasukkan ke properti set `Quantity` tidak bernilai negatif. Jika kuantitas bernilai tidak positif, maka harus diatur ke 0. Pastikan juga nilai yang dimasukkan ke properti set `Price` tidak bernilai negatif. Jika harga per barang tidak positif, harus diatur ke 0,0. Kelas `Invoice` harus memiliki sebuah konstruktor yang menginisialisasi keempat variabel instan tersebut. Pastikan parameter input `quantity`, dan `price` divalidasi di konstruktor sesuai dengan aturan. Selain itu, sediakan sebuah metode yang bernama `GetInvoiceAmount` yang menghitung jumlah faktur (yaitu, mengalikan jumlah dengan harga per barang), kemudian mengembalikan jumlah tersebut sebagai nilai double. Tulis sebuah kelas publik bernama `Program` yang berisi metode statik `Main` yang mendemonstrasikan kemampuan dari kelas `Invoice`.

### Employee

Buat solusi dari soal ini di project `Encapsulation` folder `Employment` dengan namespace `Encapsulation.Employment`.

Buatlah sebuah kelas publik yang bernama `Employee` yang memiliki tiga atribut private yaitu `_firstName` (tipe String), `_lastName` (tipe String), dan `_monthlySalary` (double). Sediakan pproperti publik dengan metode set dan metode get untuk masing-masing atribut `FirstName`, `LastName`, dan `MonthlySalary`. Jika inputan gaji bulanan tidak positif, maka nilai gaji bulanan yang sudah ada sebelumnya tidak perlu diubah. Sediakan sebuah konstruktor yang menginisialisasi ketiga atribut tersebut. Di konstruktor, pastikan parameter `firstName` dan `lastName` divalidasi tidak null atau string kosong. Jika input parameter `firstName` dan `lastName` null atau string kosong maka set kedua variable tersebut dengan value "Unknown". Pastikan juga parameter `montlySalary` tidak negatif. Jika input negatif maka set nilai menjadi 0,0. Buat sebuah metode publik `RaiseSalary` dengan parameter `raisePercentage` (tipe int) yang menaikkan gaji bulanan sebesar maksimal 20% dari gaji saat ini. Jika kenaikan lebih dari 20% maka pemanggilan metode `RaiseSalary` tidak berdampak pada perubahan atribut `monthlySalary`. Buat metode publik `GetYearlySalary` yang mengembalikan nilai gaji bulanan yang disetahunkan bertipe double. Tulis sebuah kelas publik bernama `Program` yang berisi metode statik `Main` yang mendemonstrasikan kemampuan dari kelas `Employee`. Buat dua objek `Employee` dan tampilkan gaji tahunan masing-masing objek. Kemudian, berikan masing-masing `Employee` kenaikan gaji sebesar 10% dan tampilkan lagi gaji tahunan masing-masing `Employee`.

### Date

Buat solusi dari soal ini di project `Encapsulation` folder `Calendar` dengan namespace `Encapsulation.Calendar`.

Buatlah sebuah kelas publik yang bernama `Date` yang tiga properti publik tanpa backing private field yaitu `Month` (tipe int), `Day` (tipe int) dan `Year` (tipe int). Pastikan setiap properti memiliki metode public get dan metode private set. Sediakan sebuah konstruktor yang menginisialisasi ketiga atribut tersebut dan pastikan dilakukan validasi. Pastikan properti `Month` hanya menyimpan nilai 1-12, properti `Day` hanya menyimpan nilai 1-31. Jika salah satu parameter tidak valid set ke bulan ke 1, hari 1, dan tahun 1970. Sediakan sebuah metode publik `DisplayDate` yang menampilkan bulan, hari, dan tahun yang dipisahkan oleh garis miring (/). Tulis sebuah kelas publik bernama `Program` yang berisi metode statik `Main` yang mendemonstrasikan kemampuan dari kelas `Date`.

### Banking

Buat solusi dari soal ini di project `Encapsulation` folder `Banking` dengan namespace `Encapsulation.Banking`.

Buatlah sebuah kelas publik yang bernama `BankAccount` yang memiliki tiga atribut private yaitu `_accountNumber` (tipe String), `_accountHolder` (tipe String), dan `_balance` (double). Sediakan properti publik dengan metode set dan metode get untuk masing-masing atribut `AccountNumber`, `AccountHolder`, dan `Balance`. 

- Jika inputan untuk `Balance` adalah negatif saat pembuatan akun, set nilai saldo awal menjadi 0,0.
- Sediakan sebuah konstruktor yang menginisialisasi ketiga atribut tersebut.
  - Di konstruktor, pastikan parameter `accountNumber` dan `accountHolder` divalidasi tidak null atau string kosong. Jika input parameter `accountNumber` atau `accountHolder` null atau string kosong maka set kedua variabel tersebut dengan value "Unknown".
  - Pastikan juga parameter `balance` tidak negatif. Jika input negatif maka set nilai menjadi 0,0.
- Buat sebuah metode publik `Deposit` dengan parameter `amount` (tipe double) yang menambahkan jumlah uang ke dalam saldo. Pastikan `amount` tidak negatif; jika negatif, tidak ada perubahan pada saldo.
- Buat sebuah metode publik `Withdraw` dengan parameter `amount` (tipe double) yang mengurangi jumlah uang dari saldo. Pastikan saldo tidak akan negatif setelah penarikan dan `amount` tidak negatif; jika kondisi tersebut tidak terpenuhi, tidak ada perubahan pada saldo.
- Buat metode publik `GetBalance` yang mengembalikan nilai saldo saat ini bertipe double.
- Tulis sebuah kelas publik bernama `Program` yang berisi metode statik `Main` yang mendemonstrasikan kemampuan dari kelas `BankAccount`. Buat sebuah objek `BankAccount`, lakukan beberapa operasi `Deposit` dan `Withdraw`, kemudian tampilkan saldo akhir.

### Extra

> Saatnya Kreatif!

Buat soal Anda sendiri dan solusinya di project `Encapsulation` folder `Extra` dengan namespace `Encapsulation.Extra` di file `Extra.cs`.

Buat spesifikasi soal Anda sendiri yang memuat hal-hal sebagai berikut:

- Nama kelas yang dibuat dan kegunaannya.
- Atribut dan properti apa saja yang harus ada di kelas.
- Metode apa saja yang dibutuhkan.
- Validasi atau aturan apa yang harus dilakukan.

Kemudian, implementasikan solusi kelas dari soal Anda di file `Extra.cs` dan eksekusi implementasinya di `Program.cs`.

=== Selesai ===


