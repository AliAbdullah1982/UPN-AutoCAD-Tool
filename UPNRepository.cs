using System.Collections.Generic;

public static class UPNRepository
{
    public static List<UPNSection> GetAll()
    {
        return new List<UPNSection>()
        {
            new UPNSection { Name="UPN50",  UPNHeight=50,  UPNFlangeWidth=38,  UPNWebThickness=5,   UPNFlangeThickness=7,   UPNRootRadius=7,   UPNToeRadius=3.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN65",  UPNHeight=65,  UPNFlangeWidth=42,  UPNWebThickness=5.5, UPNFlangeThickness=7.5, UPNRootRadius=7.5, UPNToeRadius=4,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN80",  UPNHeight=80,  UPNFlangeWidth=45,  UPNWebThickness=6,   UPNFlangeThickness=8,   UPNRootRadius=8,   UPNToeRadius=4,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN100", UPNHeight=100, UPNFlangeWidth=50,  UPNWebThickness=6,   UPNFlangeThickness=8.5, UPNRootRadius=8.5, UPNToeRadius=4.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN120", UPNHeight=120, UPNFlangeWidth=55,  UPNWebThickness=7,   UPNFlangeThickness=9,   UPNRootRadius=9,   UPNToeRadius=4.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN140", UPNHeight=140, UPNFlangeWidth=60,  UPNWebThickness=7,   UPNFlangeThickness=10,  UPNRootRadius=10,  UPNToeRadius=5,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN160", UPNHeight=160, UPNFlangeWidth=65,  UPNWebThickness=7.5, UPNFlangeThickness=10.5,UPNRootRadius=10.5,UPNToeRadius=5.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN180", UPNHeight=180, UPNFlangeWidth=70,  UPNWebThickness=8,   UPNFlangeThickness=11,  UPNRootRadius=11,  UPNToeRadius=5.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN200", UPNHeight=200, UPNFlangeWidth=75,  UPNWebThickness=8.5, UPNFlangeThickness=11.5,UPNRootRadius=11.5,UPNToeRadius=6,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN220", UPNHeight=220, UPNFlangeWidth=80,  UPNWebThickness=9,   UPNFlangeThickness=12.5,UPNRootRadius=12.5,UPNToeRadius=6.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN240", UPNHeight=240, UPNFlangeWidth=85,  UPNWebThickness=9.5, UPNFlangeThickness=13,  UPNRootRadius=13,  UPNToeRadius=6.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN260", UPNHeight=260, UPNFlangeWidth=90,  UPNWebThickness=10,  UPNFlangeThickness=14,  UPNRootRadius=14,  UPNToeRadius=7,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN280", UPNHeight=280, UPNFlangeWidth=95,  UPNWebThickness=10,  UPNFlangeThickness=15,  UPNRootRadius=15,  UPNToeRadius=7.5, UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN300", UPNHeight=300, UPNFlangeWidth=100, UPNWebThickness=10,  UPNFlangeThickness=16,  UPNRootRadius=16,  UPNToeRadius=8,   UPNFlangeSlope=0.08 },

            new UPNSection { Name="UPN320", UPNHeight=320, UPNFlangeWidth=100, UPNWebThickness=14,  UPNFlangeThickness=17.5,UPNRootRadius=17.5,UPNToeRadius=8.8, UPNFlangeSlope=0.05 },

            new UPNSection { Name="UPN350", UPNHeight=350, UPNFlangeWidth=100, UPNWebThickness=14,  UPNFlangeThickness=16,  UPNRootRadius=16,  UPNToeRadius=8,   UPNFlangeSlope=0.05 },

            new UPNSection { Name="UPN380", UPNHeight=380, UPNFlangeWidth=102, UPNWebThickness=13.5,UPNFlangeThickness=16,  UPNRootRadius=16,  UPNToeRadius=8,   UPNFlangeSlope=0.05 },

            new UPNSection { Name="UPN400", UPNHeight=400, UPNFlangeWidth=110, UPNWebThickness=14,  UPNFlangeThickness=18,  UPNRootRadius=18,  UPNToeRadius=9,   UPNFlangeSlope=0.05 }
        };
    }
}