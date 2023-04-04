using System;

class Address {
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public override string ToString() {
        return $"{street}, {city}, {state} {zip}";
    }
}

abstract class Event {
    private string title;
    private string description;
    private DateTime date;
    private Address address;

    public Event(string title, string description, DateTime date, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public string GenerateStandardDetails() {
        return $"{title}\n{description}\n{date}\n{address}";
    }

    public string GenerateFullDetails() {
        return $"{GenerateStandardDetails()}\nType: {GetType().Name}";
    }

    public string GenerateShortDescription() {
        return $"{GetType().Name}: {title} ({date.ToShortDateString()})";
    }
}

class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity)
        : base(title, description, date, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public string GenerateFullDetails() {
        return $"{base.GenerateFullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}

class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail)
        : base(title, description, date, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public string GenerateFullDetails() {
        return $"{base.GenerateFullDetails()}\nRSVP email: {rsvpEmail}";
    }
}

class OutdoorGathering : Event {
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, Address address, string weatherStatement)
        : base(title, description, date, address) {
        this.weatherStatement = weatherStatement;
    }

    public string GenerateFullDetails() {
        return $"{base.GenerateFullDetails()}\nWeather statement: {weatherStatement}";
    }
}

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Broadway", "Bigcity", "NY", "67890");
        Address address3 = new Address("789 Market St", "Smalltown", "TX", "23456");

        Event lecture = new Lecture("The History of Computing", "A fascinating look at the evolution of computing technology", new DateTime(2023, 4, 15, 14, 30, 0), address1, "Dr. John Doe", 50);
        Event reception = new Reception("Fundraiser Gala", "Join us for an evening of music and dancing to benefit local charities", new DateTime(2023, 5, 20, 18, 0, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Family Picnic", "Come enjoy a day of food and games with your family", new DateTime(2023, 6, 10, 11, 0, 0), address3, "rsvp@example.com");

        // Call GenerateFullDetails for each event and print the result to the console
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
    }}