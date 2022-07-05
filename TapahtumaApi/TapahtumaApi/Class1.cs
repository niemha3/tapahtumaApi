
public class Tapahtumat
{
    public string swagger { get; set; }
    public Info info { get; set; }
    public string host { get; set; }
    public string basePath { get; set; }
    public Tag1[] tags { get; set; }
    public Paths paths { get; set; }
    public Definitions definitions { get; set; }
}

public class Info
{
    public string description { get; set; }
    public string version { get; set; }
    public string title { get; set; }
    public Contact contact { get; set; }
    public License license { get; set; }
}

public class Contact
{
    public string name { get; set; }
}

public class License
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Paths
{
    public V2PlaceId v2placeid { get; set; }
    public V2Places v2places { get; set; }
    public V1PlaceId v1placeid { get; set; }
    public V1Places v1places { get; set; }
    public V1EventId v1eventid { get; set; }
    public V1Events v1events { get; set; }
    public V2Activities v2activities { get; set; }
    public V2ActivityId v2activityid { get; set; }
    public V1ActivityId v1activityid { get; set; }
    public V1Activities v1activities { get; set; }
}

public class V2PlaceId
{
    public Get get { get; set; }
}

public class Get
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter[] parameters { get; set; }
    public Responses responses { get; set; }
}

public class Responses
{
    public _200 _200 { get; set; }
}

public class _200
{
    public string description { get; set; }
    public Schema schema { get; set; }
}

public class Schema
{
    public string _ref { get; set; }
}

public class Parameter
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
}

public class V2Places
{
    public Get1 get { get; set; }
}

public class Get1
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter1[] parameters { get; set; }
    public Responses1 responses { get; set; }
}

public class Responses1
{
    public _2001 _200 { get; set; }
}

public class _2001
{
    public string description { get; set; }
    public Schema1 schema { get; set; }
}

public class Schema1
{
    public string type { get; set; }
    public Items items { get; set; }
}

public class Items
{
    public string _ref { get; set; }
}

public class Parameter1
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string format { get; set; }
}

public class V1PlaceId
{
    public Get2 get { get; set; }
}

public class Get2
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter2[] parameters { get; set; }
    public Responses2 responses { get; set; }
}

public class Responses2
{
    public _2002 _200 { get; set; }
}

public class _2002
{
    public string description { get; set; }
    public Schema2 schema { get; set; }
}

public class Schema2
{
    public string _ref { get; set; }
}

public class Parameter2
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
}

public class V1Places
{
    public Get3 get { get; set; }
}

public class Get3
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter3[] parameters { get; set; }
    public Responses3 responses { get; set; }
}

public class Responses3
{
    public _2003 _200 { get; set; }
}

public class _2003
{
    public string description { get; set; }
    public Schema3 schema { get; set; }
}

public class Schema3
{
    public string type { get; set; }
    public Items1 items { get; set; }
}

public class Items1
{
    public string _ref { get; set; }
}

public class Parameter3
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string format { get; set; }
}

public class V1EventId
{
    public Get4 get { get; set; }
}

public class Get4
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter4[] parameters { get; set; }
    public Responses4 responses { get; set; }
}

public class Responses4
{
    public _2004 _200 { get; set; }
}

public class _2004
{
    public string description { get; set; }
    public Schema4 schema { get; set; }
}

public class Schema4
{
    public string _ref { get; set; }
}

public class Parameter4
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
}

public class V1Events
{
    public Get5 get { get; set; }
}

public class Get5
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter5[] parameters { get; set; }
    public Responses5 responses { get; set; }
}

public class Responses5
{
    public _2005 _200 { get; set; }
}

public class _2005
{
    public string description { get; set; }
    public Schema5 schema { get; set; }
}

public class Schema5
{
    public string type { get; set; }
    public Items2 items { get; set; }
}

public class Items2
{
    public string _ref { get; set; }
}

public class Parameter5
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string format { get; set; }
}

public class V2Activities
{
    public Get6 get { get; set; }
}

public class Get6
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter6[] parameters { get; set; }
    public Responses6 responses { get; set; }
}

public class Responses6
{
    public _2006 _200 { get; set; }
}

public class _2006
{
    public string description { get; set; }
    public Schema6 schema { get; set; }
}

public class Schema6
{
    public string _ref { get; set; }
}

public class Parameter6
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string format { get; set; }
}

public class V2ActivityId
{
    public Get7 get { get; set; }
}

public class Get7
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter7[] parameters { get; set; }
    public Responses7 responses { get; set; }
}

public class Responses7
{
    public _2007 _200 { get; set; }
}

public class _2007
{
    public string description { get; set; }
    public Schema7 schema { get; set; }
}

public class Schema7
{
    public string _ref { get; set; }
}

public class Parameter7
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
}

public class V1ActivityId
{
    public Get8 get { get; set; }
}

public class Get8
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter8[] parameters { get; set; }
    public Responses8 responses { get; set; }
}

public class Responses8
{
    public _2008 _200 { get; set; }
}

public class _2008
{
    public string description { get; set; }
    public Schema8 schema { get; set; }
}

public class Schema8
{
    public string _ref { get; set; }
}

public class Parameter8
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
}

public class V1Activities
{
    public Get9 get { get; set; }
}

public class Get9
{
    public string[] tags { get; set; }
    public string summary { get; set; }
    public string description { get; set; }
    public string operationId { get; set; }
    public string[] produces { get; set; }
    public Parameter9[] parameters { get; set; }
    public Responses9 responses { get; set; }
}

public class Responses9
{
    public _2009 _200 { get; set; }
}

public class _2009
{
    public string description { get; set; }
    public Schema9 schema { get; set; }
}

public class Schema9
{
    public string type { get; set; }
    public Items3 items { get; set; }
}

public class Items3
{
    public string _ref { get; set; }
}

public class Parameter9
{
    public string name { get; set; }
    public string _in { get; set; }
    public string description { get; set; }
    public bool required { get; set; }
    public string type { get; set; }
    public string format { get; set; }
}

public class Definitions
{
    public Address Address { get; set; }
    public Descriptiontranslated DescriptionTranslated { get; set; }
    public Image Image { get; set; }
    public License_Type License_type { get; set; }
    public Location Location { get; set; }
    public Name Name { get; set; }
    public Placev2 PlaceV2 { get; set; }
    public Sourcetype1 SourceType { get; set; }
    public Tag Tag { get; set; }
    public Openinghour OpeningHour { get; set; }
    public Openinghourtime OpeningHourTime { get; set; }
    public Openinghourstranslated OpeningHoursTranslated { get; set; }
    public Place Place { get; set; }
    public Event Event { get; set; }
    public Eventdates1 EventDates { get; set; }
    public Translatedstring TranslatedString { get; set; }
    public Activityv2 ActivityV2 { get; set; }
    public Allitemsresponse AllItemsResponse { get; set; }
    public Company1 Company { get; set; }
    public Coordinate Coordinate { get; set; }
    public Description3 Description { get; set; }
    public Media1 Media { get; set; }
    public Openinghours1 OpeningHours { get; set; }
    public Price Price { get; set; }
    public Activity Activity { get; set; }
    public Wherewhendurationtranslated WhereWhenDurationTranslated { get; set; }
}

public class Address
{
    public string type { get; set; }
    public Properties properties { get; set; }
}

public class Properties
{
    public Streetaddress streetAddress { get; set; }
    public Postalcode postalCode { get; set; }
    public Locality locality { get; set; }
    public Neighbourhood neighbourhood { get; set; }
}

public class Streetaddress
{
    public string type { get; set; }
}

public class Postalcode
{
    public string type { get; set; }
}

public class Locality
{
    public string type { get; set; }
}

public class Neighbourhood
{
    public string type { get; set; }
}

public class Descriptiontranslated
{
    public string type { get; set; }
    public Properties1 properties { get; set; }
}

public class Properties1
{
    public Intro intro { get; set; }
    public Body body { get; set; }
    public Images images { get; set; }
}

public class Intro
{
    public string type { get; set; }
}

public class Body
{
    public string type { get; set; }
}

public class Images
{
    public string type { get; set; }
    public Items4 items { get; set; }
}

public class Items4
{
    public string _ref { get; set; }
}

public class Image
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties2 properties { get; set; }
}

public class Properties2
{
    public Url url { get; set; }
    public Copyrightholder copyrightHolder { get; set; }
    public Licensetype licenseType { get; set; }
    public Media_Id media_id { get; set; }
}

public class Url
{
    public string type { get; set; }
}

public class Copyrightholder
{
    public string type { get; set; }
}

public class Licensetype
{
    public string _ref { get; set; }
}

public class Media_Id
{
    public string type { get; set; }
}

public class License_Type
{
    public string type { get; set; }
}

public class Location
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties3 properties { get; set; }
}

public class Properties3
{
    public Lat lat { get; set; }
    public Lon lon { get; set; }
    public Address1 address { get; set; }
}

public class Lat
{
    public string type { get; set; }
}

public class Lon
{
    public string type { get; set; }
}

public class Address1
{
    public string _ref { get; set; }
}

public class Name
{
    public string type { get; set; }
    public Properties4 properties { get; set; }
}

public class Properties4
{
    public Fi fi { get; set; }
    public En en { get; set; }
    public Sv sv { get; set; }
    public Zh zh { get; set; }
}

public class Fi
{
    public string type { get; set; }
}

public class En
{
    public string type { get; set; }
}

public class Sv
{
    public string type { get; set; }
}

public class Zh
{
    public string type { get; set; }
}

public class Placev2
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties5 properties { get; set; }
}

public class Properties5
{
    public Id id { get; set; }
    public Name1 name { get; set; }
    public Sourcetype sourceType { get; set; }
    public Infourl infoUrl { get; set; }
    public Modifiedat modifiedAt { get; set; }
    public Location1 location { get; set; }
    public Description description { get; set; }
    public Tags tags { get; set; }
    public Extra_Searchwords extra_searchwords { get; set; }
    public Openinghoursurl openingHoursUrl { get; set; }
}

public class Id
{
    public string type { get; set; }
}

public class Name1
{
    public string _ref { get; set; }
}

public class Sourcetype
{
    public string _ref { get; set; }
}

public class Infourl
{
    public string type { get; set; }
}

public class Modifiedat
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Location1
{
    public string _ref { get; set; }
}

public class Description
{
    public string _ref { get; set; }
}

public class Tags
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items5 items { get; set; }
}

public class Items5
{
    public string _ref { get; set; }
}

public class Extra_Searchwords
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items6 items { get; set; }
}

public class Items6
{
    public string type { get; set; }
}

public class Openinghoursurl
{
    public string type { get; set; }
}

public class Sourcetype1
{
    public string type { get; set; }
}

public class Tag
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties6 properties { get; set; }
}

public class Properties6
{
    public Id1 id { get; set; }
    public Name2 name { get; set; }
}

public class Id1
{
    public string type { get; set; }
}

public class Name2
{
    public string type { get; set; }
}

public class Openinghour
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties7 properties { get; set; }
}

public class Properties7
{
    public Weekdayid weekdayId { get; set; }
    public Opens opens { get; set; }
    public Closes closes { get; set; }
    public Open24h open24h { get; set; }
}

public class Weekdayid
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Opens
{
    public string _ref { get; set; }
}

public class Closes
{
    public string _ref { get; set; }
}

public class Open24h
{
    public string type { get; set; }
}

public class Openinghourtime
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties8 properties { get; set; }
}

public class Properties8
{
    public Hours hours { get; set; }
    public Minutes minutes { get; set; }
    public Seconds seconds { get; set; }
}

public class Hours
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Minutes
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Seconds
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Openinghourstranslated
{
    public string type { get; set; }
    public Properties9 properties { get; set; }
}

public class Properties9
{
    public Hours1 hours { get; set; }
    public Openinghoursexception openinghoursException { get; set; }
}

public class Hours1
{
    public string type { get; set; }
    public Items7 items { get; set; }
}

public class Items7
{
    public string _ref { get; set; }
}

public class Openinghoursexception
{
    public string type { get; set; }
}

public class Place
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties10 properties { get; set; }
}

public class Properties10
{
    public Id2 id { get; set; }
    public Name3 name { get; set; }
    public Sourcetype2 sourceType { get; set; }
    public Infourl1 infoUrl { get; set; }
    public Modifiedat1 modifiedAt { get; set; }
    public Location2 location { get; set; }
    public Description1 description { get; set; }
    public Tags1 tags { get; set; }
    public Openinghours openingHours { get; set; }
    public Extra_Searchwords1 extra_searchwords { get; set; }
}

public class Id2
{
    public string type { get; set; }
}

public class Name3
{
    public string _ref { get; set; }
}

public class Sourcetype2
{
    public string _ref { get; set; }
}

public class Infourl1
{
    public string type { get; set; }
}

public class Modifiedat1
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Location2
{
    public string _ref { get; set; }
}

public class Description1
{
    public string _ref { get; set; }
}

public class Tags1
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items8 items { get; set; }
}

public class Items8
{
    public string _ref { get; set; }
}

public class Openinghours
{
    public string _ref { get; set; }
}

public class Extra_Searchwords1
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items9 items { get; set; }
}

public class Items9
{
    public string type { get; set; }
}

public class Event
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties11 properties { get; set; }
}

public class Properties11
{
    public Id3 id { get; set; }
    public Name4 name { get; set; }
    public Sourcetype3 sourceType { get; set; }
    public Infourl2 infoUrl { get; set; }
    public Modifiedat2 modifiedAt { get; set; }
    public Location3 location { get; set; }
    public Description2 description { get; set; }
    public Tags2 tags { get; set; }
    public Eventdates eventDates { get; set; }
}

public class Id3
{
    public string type { get; set; }
}

public class Name4
{
    public string _ref { get; set; }
}

public class Sourcetype3
{
    public string _ref { get; set; }
}

public class Infourl2
{
    public string type { get; set; }
}

public class Modifiedat2
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Location3
{
    public string _ref { get; set; }
}

public class Description2
{
    public string _ref { get; set; }
}

public class Tags2
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items10 items { get; set; }
}

public class Items10
{
    public string _ref { get; set; }
}

public class Eventdates
{
    public string _ref { get; set; }
}

public class Eventdates1
{
    public string type { get; set; }
    public Properties12 properties { get; set; }
}

public class Properties12
{
    public Startingday startingDay { get; set; }
    public Endingday endingDay { get; set; }
    public Additionaldescription additionalDescription { get; set; }
}

public class Startingday
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Endingday
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Additionaldescription
{
    public string type { get; set; }
    public Items11 items { get; set; }
}

public class Items11
{
    public string _ref { get; set; }
}

public class Translatedstring
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties13 properties { get; set; }
}

public class Properties13
{
    public Langcode langCode { get; set; }
    public Text text { get; set; }
}

public class Langcode
{
    public string type { get; set; }
}

public class Text
{
    public string type { get; set; }
}

public class Activityv2
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties14 properties { get; set; }
}

public class Properties14
{
    public Id4 id { get; set; }
    public Updated updated { get; set; }
    public Descriptions descriptions { get; set; }
    public Company company { get; set; }
    public Open open { get; set; }
    public Media media { get; set; }
    public Address2 address { get; set; }
    public Companyaddress companyAddress { get; set; }
    public Tags3 tags { get; set; }
    public Siteurl siteUrl { get; set; }
    public Storeurl storeUrl { get; set; }
    public Priceeur priceEUR { get; set; }
    public Availablemonths availableMonths { get; set; }
    public Meantfor meantFor { get; set; }
    public Duration duration { get; set; }
    public Durationtype durationType { get; set; }
}

public class Id4
{
    public string type { get; set; }
}

public class Updated
{
    public string type { get; set; }
}

public class Descriptions
{
    public string type { get; set; }
    public Additionalproperties additionalProperties { get; set; }
}

public class Additionalproperties
{
    public string _ref { get; set; }
}

public class Company
{
    public string _ref { get; set; }
}

public class Open
{
    public string type { get; set; }
    public Additionalproperties1 additionalProperties { get; set; }
}

public class Additionalproperties1
{
    public string _ref { get; set; }
}

public class Media
{
    public string type { get; set; }
    public Items12 items { get; set; }
}

public class Items12
{
    public string _ref { get; set; }
}

public class Address2
{
    public string _ref { get; set; }
}

public class Companyaddress
{
    public string _ref { get; set; }
}

public class Tags3
{
    public string type { get; set; }
    public Items13 items { get; set; }
}

public class Items13
{
    public string type { get; set; }
}

public class Siteurl
{
    public string type { get; set; }
}

public class Storeurl
{
    public string type { get; set; }
}

public class Priceeur
{
    public string _ref { get; set; }
}

public class Availablemonths
{
    public string type { get; set; }
    public Items14 items { get; set; }
}

public class Items14
{
    public string type { get; set; }
}

public class Meantfor
{
    public string type { get; set; }
    public Items15 items { get; set; }
}

public class Items15
{
    public string type { get; set; }
}

public class Duration
{
    public string type { get; set; }
}

public class Durationtype
{
    public string type { get; set; }
}

public class Allitemsresponse
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties15 properties { get; set; }
}

public class Properties15
{
    public Offset offset { get; set; }
    public Count count { get; set; }
    public Rows rows { get; set; }
}

public class Offset
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Count
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Rows
{
    public string type { get; set; }
    public Items16 items { get; set; }
}

public class Items16
{
    public string _ref { get; set; }
}

public class Company1
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties16 properties { get; set; }
}

public class Properties16
{
    public Name5 name { get; set; }
    public Businessid businessId { get; set; }
    public Email email { get; set; }
    public Phone phone { get; set; }
}

public class Name5
{
    public string type { get; set; }
}

public class Businessid
{
    public string type { get; set; }
}

public class Email
{
    public string type { get; set; }
}

public class Phone
{
    public string type { get; set; }
}

public class Coordinate
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties17 properties { get; set; }
}

public class Properties17
{
    public Latitude latitude { get; set; }
    public Longitude longitude { get; set; }
}

public class Latitude
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Longitude
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Description3
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties18 properties { get; set; }
}

public class Properties18
{
    public Name6 name { get; set; }
    public Description4 description { get; set; }
    public Siteurl1 siteUrl { get; set; }
    public Storeurl1 storeUrl { get; set; }
}

public class Name6
{
    public string type { get; set; }
}

public class Description4
{
    public string type { get; set; }
}

public class Siteurl1
{
    public string type { get; set; }
}

public class Storeurl1
{
    public string type { get; set; }
}

public class Media1
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties19 properties { get; set; }
}

public class Properties19
{
    public Id5 id { get; set; }
    public Kind kind { get; set; }
    public Copyright copyright { get; set; }
    public Name7 name { get; set; }
    public Alt alt { get; set; }
    public Smallurl smallUrl { get; set; }
    public Originalurl originalUrl { get; set; }
    public Largeurl largeUrl { get; set; }
}

public class Id5
{
    public string type { get; set; }
}

public class Kind
{
    public string type { get; set; }
}

public class Copyright
{
    public string type { get; set; }
}

public class Name7
{
    public string type { get; set; }
}

public class Alt
{
    public string type { get; set; }
}

public class Smallurl
{
    public string type { get; set; }
}

public class Originalurl
{
    public string type { get; set; }
}

public class Largeurl
{
    public string type { get; set; }
}

public class Openinghours1
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties20 properties { get; set; }
}

public class Properties20
{
    public Open1 open { get; set; }
    public From from { get; set; }
    public To to { get; set; }
}

public class Open1
{
    public string type { get; set; }
}

public class From
{
    public string type { get; set; }
}

public class To
{
    public string type { get; set; }
}

public class Price
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties21 properties { get; set; }
}

public class Properties21
{
    public From1 from { get; set; }
    public To1 to { get; set; }
    public Pricingtype pricingType { get; set; }
}

public class From1
{
    public string type { get; set; }
}

public class To1
{
    public string type { get; set; }
}

public class Pricingtype
{
    public string type { get; set; }
}

public class Activity
{
    public string type { get; set; }
    public string[] required { get; set; }
    public Properties22 properties { get; set; }
}

public class Properties22
{
    public Id6 id { get; set; }
    public Name8 name { get; set; }
    public Sourcetype4 sourceType { get; set; }
    public Infourl3 infoUrl { get; set; }
    public Modifiedat3 modifiedAt { get; set; }
    public Location4 location { get; set; }
    public Description5 description { get; set; }
    public Tags4 tags { get; set; }
    public Wherewhenduration whereWhenDuration { get; set; }
}

public class Id6
{
    public string type { get; set; }
}

public class Name8
{
    public string _ref { get; set; }
}

public class Sourcetype4
{
    public string _ref { get; set; }
}

public class Infourl3
{
    public string type { get; set; }
}

public class Modifiedat3
{
    public string type { get; set; }
    public string format { get; set; }
}

public class Location4
{
    public string _ref { get; set; }
}

public class Description5
{
    public string _ref { get; set; }
}

public class Tags4
{
    public string type { get; set; }
    public bool uniqueItems { get; set; }
    public Items17 items { get; set; }
}

public class Items17
{
    public string _ref { get; set; }
}

public class Wherewhenduration
{
    public string _ref { get; set; }
}

public class Wherewhendurationtranslated
{
    public string type { get; set; }
    public Properties23 properties { get; set; }
}

public class Properties23
{
    public Whereandwhen whereAndWhen { get; set; }
    public Duration1 duration { get; set; }
}

public class Whereandwhen
{
    public string type { get; set; }
}

public class Duration1
{
    public string type { get; set; }
}

public class Tag1
{
    public string name { get; set; }
}
