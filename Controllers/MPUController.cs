using ApiMpu9250.Context;
using ApiMpu9250.Domain;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiMpu9250.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MPUController : ControllerBase
{
    private readonly MPUDbContext mPUDbContext;

    public MPUController(MPUDbContext mPUDbContext)
    {
        this.mPUDbContext = mPUDbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MPU>>> GetMPUs()
    {
        var mpus = await mPUDbContext.Mpus.ToListAsync();
        return Ok(mpus);
    }

    [HttpPost]
    public async Task<ActionResult<MPU>> CreateMpu(MPUDto mPUDto)
    {
        var mpu = new MPU
        {
            Ax = mPUDto.Ax,
            Ay = mPUDto.Ay,
            Az = mPUDto.Az,
            Gx = mPUDto.Gx,
            Gy = mPUDto.Gy,
            Gz = mPUDto.Gz,
            Mx = mPUDto.Mx,
            My = mPUDto.My,
            Mz = mPUDto.Mz,
            Pitch = mPUDto.Pitch,
            Roll = mPUDto.Roll,
            Yaw = mPUDto.Yaw,
        };

        mPUDbContext.Mpus.Add(mpu);
        await mPUDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<MPU>> UpdateMpu(MPUDto mPUDto)
    {
        var existingMpu = await mPUDbContext.Mpus.FirstOrDefaultAsync();

        if (existingMpu != null)
        {
            existingMpu.Ax = mPUDto.Ax;
            existingMpu.Ay = mPUDto.Ay;
            existingMpu.Az = mPUDto.Az;
            existingMpu.Gx = mPUDto.Gx;
            existingMpu.Gy = mPUDto.Gy;
            existingMpu.Gz = mPUDto.Gz;
            existingMpu.Mx = mPUDto.Mx;
            existingMpu.My = mPUDto.My;
            existingMpu.Mz = mPUDto.Mz;
            existingMpu.Pitch = mPUDto.Pitch;
            existingMpu.Roll = mPUDto.Roll;
            existingMpu.Yaw = mPUDto.Yaw;

            await mPUDbContext.SaveChangesAsync();

            return Ok();
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMpu(int id)
    {
        var mpu = await mPUDbContext.Mpus.FindAsync(id);
        if (mpu == null)
        {
            return NotFound();
        }

        mPUDbContext.Remove(mpu);
        await mPUDbContext.SaveChangesAsync();

        return NoContent();
    }
}
