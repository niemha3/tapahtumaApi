using System;
using System.Collections.Generic;
using System.Text;

namespace TapahtumaApi
{

    public class ActivitiesList
    {
        public Meta meta { get; set; }
        public Datum44[] data { get; set; }
        public Tags tags { get; set; }
    }

    public class Meta44
    {
        public string count { get; set; }
    }

    public class Tags44
    {
        public string myhelsinki10 { get; set; }
        public string myhelsinki1016 { get; set; }
        public string myhelsinki1033 { get; set; }
        public string myhelsinki1283 { get; set; }
        public string myhelsinki1344 { get; set; }
        public string myhelsinki1471 { get; set; }
        public string myhelsinki1481 { get; set; }
        public string myhelsinki1572 { get; set; }
        public string myhelsinki1749 { get; set; }
        public string myhelsinki1822 { get; set; }
        public string myhelsinki2 { get; set; }
        public string myhelsinki222 { get; set; }
        public string myhelsinki223 { get; set; }
        public string myhelsinki226 { get; set; }
        public string myhelsinki239 { get; set; }
        public string myhelsinki240 { get; set; }
        public string myhelsinki252 { get; set; }
        public string myhelsinki257 { get; set; }
        public string myhelsinki2605 { get; set; }
        public string myhelsinki2606 { get; set; }
        public string myhelsinki2607 { get; set; }
        public string myhelsinki2608 { get; set; }
        public string myhelsinki2609 { get; set; }
        public string myhelsinki2610 { get; set; }
        public string myhelsinki2611 { get; set; }
        public string myhelsinki2612 { get; set; }
        public string myhelsinki2613 { get; set; }
        public string myhelsinki2614 { get; set; }
        public string myhelsinki2615 { get; set; }
        public string myhelsinki2616 { get; set; }
        public string myhelsinki2617 { get; set; }
        public string myhelsinki2618 { get; set; }
        public string myhelsinki2619 { get; set; }
        public string myhelsinki2620 { get; set; }
        public string myhelsinki2621 { get; set; }
        public string myhelsinki2622 { get; set; }
        public string myhelsinki2623 { get; set; }
        public string myhelsinki2624 { get; set; }
        public string myhelsinki2625 { get; set; }
        public string myhelsinki2626 { get; set; }
        public string myhelsinki2627 { get; set; }
        public string myhelsinki2628 { get; set; }
        public string myhelsinki274 { get; set; }
        public string myhelsinki285 { get; set; }
        public string myhelsinki287 { get; set; }
        public string myhelsinki342 { get; set; }
        public string myhelsinki346 { get; set; }
        public string myhelsinki352 { get; set; }
        public string myhelsinki364 { get; set; }
        public string myhelsinki395 { get; set; }
        public string myhelsinki396 { get; set; }
        public string myhelsinki399 { get; set; }
        public string myhelsinki40 { get; set; }
        public string myhelsinki401 { get; set; }
        public string myhelsinki421 { get; set; }
        public string myhelsinki43 { get; set; }
        public string myhelsinki437 { get; set; }
        public string myhelsinki449 { get; set; }
        public string myhelsinki45 { get; set; }
        public string myhelsinki453 { get; set; }
        public string myhelsinki46 { get; set; }
        public string myhelsinki47 { get; set; }
        public string myhelsinki531 { get; set; }
        public string myhelsinki546 { get; set; }
        public string myhelsinki56 { get; set; }
        public string myhelsinki568 { get; set; }
        public string myhelsinki579 { get; set; }
        public string myhelsinki616 { get; set; }
        public string myhelsinki648 { get; set; }
        public string myhelsinki655 { get; set; }
        public string myhelsinki678 { get; set; }
        public string myhelsinki679 { get; set; }
        public string myhelsinki680 { get; set; }
        public string myhelsinki681 { get; set; }
        public string myhelsinki682 { get; set; }
        public string myhelsinki701 { get; set; }
        public string myhelsinki703 { get; set; }
        public string myhelsinki747 { get; set; }
        public string myhelsinki757 { get; set; }
        public string myhelsinki759 { get; set; }
        public string myhelsinki793 { get; set; }
        public string myhelsinki836 { get; set; }
        public string myhelsinki864 { get; set; }
        public string myhelsinki903 { get; set; }
        public string myhelsinki921 { get; set; }
        public string myhelsinki922 { get; set; }
    }

    public class Datum44
    {
        public string id { get; set; }
        public Name name { get; set; }
        public Source_Type source_type { get; set; }
        public string info_url { get; set; }
        public DateTime modified_at { get; set; }
        public Location location { get; set; }
        public Description description { get; set; }
        public Tag[] tags { get; set; }
        public Where_When_Duration44 where_when_duration { get; set; }
    }

    public class Name44
    {
        public string fi { get; set; }
        public string en { get; set; }
        public string sv { get; set; }
        public object zh { get; set; }
    }

    public class Source_Type44
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Location44
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public Address address { get; set; }
    }

    public class Address44
    {
        public string street_address { get; set; }
        public string postal_code { get; set; }
        public string locality { get; set; }
        public object neighbourhood { get; set; }
    }

    public class Description44
    {
        public object intro { get; set; }
        public string body { get; set; }
        public Image[] images { get; set; }
    }

    public class Image44
    {
        public string url { get; set; }
        public string copyright_holder { get; set; }
        public License_Type license_type { get; set; }
        public object media_id { get; set; }
    }

    public class License_Type44
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Where_When_Duration44
    {
        public string where_and_when { get; set; }
        public string duration { get; set; }
    }

    public class Tag44
    {
        public string id { get; set; }
        public string name { get; set; }
    }



}
