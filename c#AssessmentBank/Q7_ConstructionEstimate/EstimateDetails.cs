public class EstimateDetails
{
    public float ConstructionArea {get; set;}
    public float SiteArea {get; set;}

    public static EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea <= siteArea)
        {
            return new EstimateDetails
            {
                ConstructionArea = constructionArea,
                SiteArea = siteArea
            };
        }
        else
        {
            throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved");
        }
    }
}

public class ConstructionEstimateException: Exception
{
    public ConstructionEstimateException(string msg): base(msg)
    {
        
        
    }
}