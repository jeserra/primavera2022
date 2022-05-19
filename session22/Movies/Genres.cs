
[Flags]
public enum Genre 
{ 
    None = 0,
    Science = 1,
    Fiction = 2, 
    // Science + Fiction = 3,
    Comedy = 4, 
    // Science + Comedy = 5,
    // Fiction + Comedy = 6,
    // Science + Fiction + Comedy = 7
    Family = 8,
    Adventure = 16,
    Fantasy = 32,
    Crime = 64,
    Romance = 128,
    Drama = 256,
    Horror = 512, 
    SciFi = 1024,
    Action = 2048, 
    Mystery = 4096,
}