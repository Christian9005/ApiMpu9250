using System.ComponentModel.DataAnnotations;

namespace ApiMpu9250.Domain;

public class MPU
{
    [Key]
    public int Id { get; set; }
    public float Ax { get; set; }
    public float Ay { get; set; }
    public float Az { get; set; }
    public float Gx { get; set; }
    public float Gy { get; set; }
    public float Gz { get; set; }
    public float Mx { get; set; }
    public float My { get; set; }
    public float Mz { get; set; }
    public float Pitch { get; set; }
    public float Roll { get; set; }
    public float Yaw { get; set; }
}
