public class room
{
    public string roomtype {  get; set; }
    public int dimenssion { get; set; }
}


//composition association

public class house
{
    public room[] rooms { get; set; }

    public house()
    {
        rooms = new room[]
        {
            new room() {roomtype = "bedroom" , dimenssion=12},
            new room() {roomtype = "hall" , dimenssion=20},
            new room() {roomtype = "kitchen" , dimenssion=14}
        };
    }
}