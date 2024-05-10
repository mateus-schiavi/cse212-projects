public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary

    public List<Feature> features {get; set;}
}

public class Properties
{
    public string place { get; set; }
    public double mag { get; set; }
}

public class Feature
{
    public Properties properties { get; set; }
}