using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Profiling
{
	public class ProfilerTask : IProfiler
	{
		public List<ExperimentResult> Measure(IRunner runner, int repetitionsCount)
		{
			var result = new List<ExperimentResult>();
		    foreach (var size in Constants.FieldCounts)
		    {
		        SpeedTime(runner, true, size, 1);
		        var classTime = SpeedTime(runner, true, size, repetitionsCount);

		        SpeedTime(runner, false, size, 1);
		        var structureTime = SpeedTime(runner, false, size, repetitionsCount);

                result.Add(new ExperimentResult(size, classTime, structureTime));
		    }
		    return result;
		}

	    double SpeedTime(IRunner runner, bool isClass, int size, int count)
	    {
	        var timer = new Stopwatch();
            timer.Start();
            runner.Call(isClass, size, count);
            timer.Stop();
	        return (double)timer.ElapsedMilliseconds / count;
	    }
	}
}
