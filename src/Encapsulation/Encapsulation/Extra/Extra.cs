using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */


// Buat solusi dari soal ini di project Encapsulation folder VideoStreaming dengan namespace Encapsulation.VideoStreaming. //

// Buatlah sebuah kelas publik yang bernama Subscription yang akan digunakan oleh layanan streaming video untuk merepresentasikan langganan pengguna. Di kelas Subscription, deklarasikan lima atribut private yaitu: _subscriptionId (tipe int), _userName (tipe string), _startDate (tipe DateTime), _endDate (tipe DateTime), dan _subscriptionDuration (tipe TimeSpan). Sediakan lima properti publik yaitu: SubscriptionId, UserName, StartDate, EndDate, dan Status yang berisi metode get untuk masing-masing atribut privat. Pastikan bahwa SubscriptionId dan StartDate tidak dapat diubah setelah objek dibuat. // 

// Kelas Subscription harus memiliki sebuah konstruktor yang menginisialisasi atribut-atribut tersebut, dengan validasi untuk memastikan bahwa subscriptionDuration tidak negatif. Jika subscriptionDuration tidak valid, harus diatur ke durasi default, misalnya 30 hari. //

// Selain itu, sediakan sebuah metode publik yang bernama ExtendSubscription yang memungkinkan perpanjangan langganan dengan menambahkan durasi baru. Validasi bahwa durasi tambahan harus lebih dari 0 hari. Jika tidak valid, lemparkan pengecualian dengan pesan yang sesuai. Metode ini harus memperbarui _endDate sesuai dengan durasi tambahan. // 

// Sediakan juga sebuah metode publik bernama DisplaySubscriptionDetails yang menampilkan detail langganan termasuk SubscriptionId, UserName, StartDate, EndDate, dan Status. //

// Tulis sebuah kelas publik bernama Program yang berisi metode statik Main yang mendemonstrasikan kemampuan dari kelas Subscription. Dalam metode Main, buatlah beberapa objek Subscription, perbarui status langganan, perpanjang langganan, dan tampilkan detail langganan. // //



/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */
public class Subscription
{
    private static int nextSubscriptionId = 1;
    private int _subscriptionId;
    private string _userName;
    private DateTime _startDate;
    private DateTime _endDate;
    private TimeSpan _subscriptionDuration;

    public Subscription(string userName, TimeSpan duration)
    {
        if (duration.TotalDays <= 0)
        {
            duration = TimeSpan.FromDays(30);
        }

        this._subscriptionId = nextSubscriptionId++;
        this._userName = userName;
        this._startDate = DateTime.Now;
        this._subscriptionDuration = duration;
        this._endDate = _startDate.Add(_subscriptionDuration);
    }

    public int SubscriptionId
    {
        get { return _subscriptionId; }
    }

    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }

    public DateTime StartDate
    {
        get { return _startDate; }
    }

    public DateTime EndDate
    {
        get { return _endDate; }
    }

    public string Status
    {
        get
        {
            return DateTime.Now > _endDate ? "Expired" : "Active";
        }
    }

    public void ExtendSubscription(TimeSpan additionalDuration)
    {
        if (additionalDuration.TotalDays <= 0)
        {
            throw new ArgumentException("Durasi perpanjangan harus lebih dari 0 hari.");
        }

        _endDate = _endDate.Add(additionalDuration);
        Console.WriteLine($"Langganan diperpanjang hingga {_endDate.ToShortDateString()}.");
    }

    public void DisplaySubscriptionDetails()
    {
        Console.WriteLine($"ID Langganan: {_subscriptionId}");
        Console.WriteLine($"Nama Pengguna: {_userName}");
        Console.WriteLine($"Tanggal Mulai: {_startDate.ToShortDateString()}");
        Console.WriteLine($"Tanggal Berakhir: {_endDate.ToShortDateString()}");
        Console.WriteLine($"Status: {Status}");
    }
}
