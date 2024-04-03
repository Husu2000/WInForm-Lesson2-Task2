namespace WinFormsApp3;

public class User
{
    private string Name_;

    public string Name
    {
        get { return Name_; }
        set { if (value.Length < 3 && value.Length > 20) throw new Exception("name length must 3/20"); Name_ = value; }
    }

    private string Surname_;

    public string Surname
    {
        get { return Surname_; }
        set { if (value.Length < 3 && value.Length > 20) throw new Exception("surname length must 3/20"); Surname_ = value; }
    }

    private string Profession_;
    public string Profession
    {
        get { return Profession_; }
        set { if (value.Length < 3 && value.Length > 20) throw new Exception("Profession length must 3/20"); Profession_ = value; }
    }

    private string Country_;
    public string Country {
        get { return Country_; }
        set{ if (value.Length < 3 && value.Length > 20) throw new Exception("Conuntry length must 3/20"); Country_ = value; } 
    }


    private string City_;
    public string City {
        get {return City_;}
        set { if (value.Length < 3 && value.Length > 20) throw new Exception("City length must 3/20"); City_ = value; } 
    }

    private int Phone_;
    public int Phone { 
        get { } 
        set { } 
    }

    public DateTime dateTime_;

    public string Gender_;


        

}
