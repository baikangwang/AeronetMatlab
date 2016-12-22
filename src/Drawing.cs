/*
* MATLAB Compiler: 4.17 (R2012a)
* Date: Thu Dec 22 00:43:56 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:AeronetDraw,Drawing,4.0," "-T" "link:lib"
* "-d" "F:\Projects\Peach\AeronetMatlab\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v"
* "class{Drawing:F:\Projects\Peach\AeronetMatlab\DrawAeronetInversions.m,F:\Projects\Peach
* \AeronetMatlab\DrawSSA.m,F:\Projects\Peach\AeronetMatlab\DrawSSAStatistisc.m,F:\Projects
* \Peach\AeronetMatlab\MatrixAeronet.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace AeronetDraw
{

  /// <summary>
  /// The Drawing class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// F:\Projects\Peach\AeronetMatlab\DrawAeronetInversions.m
  /// <newpara></newpara>
  /// F:\Projects\Peach\AeronetMatlab\DrawSSA.m
  /// <newpara></newpara>
  /// F:\Projects\Peach\AeronetMatlab\DrawSSAStatistisc.m
  /// <newpara></newpara>
  /// F:\Projects\Peach\AeronetMatlab\MatrixAeronet.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class Drawing : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Drawing()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "AeronetDraw.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Drawing class.
    /// </summary>
    public Drawing()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Drawing()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    ///
    public void DrawAeronetInversions()
    {
      mcr.EvaluateFunction(0, "DrawAeronetInversions", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    ///
    public void DrawAeronetInversions(MWArray stats_inversion)
    {
      mcr.EvaluateFunction(0, "DrawAeronetInversions", stats_inversion);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    ///
    public void DrawAeronetInversions(MWArray stats_inversion, MWArray r)
    {
      mcr.EvaluateFunction(0, "DrawAeronetInversions", stats_inversion, r);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="outputbase">Input argument #3</param>
    ///
    public void DrawAeronetInversions(MWArray stats_inversion, MWArray r, MWArray 
                                outputbase)
    {
      mcr.EvaluateFunction(0, "DrawAeronetInversions", stats_inversion, r, outputbase);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawAeronetInversions(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawAeronetInversions", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawAeronetInversions(int numArgsOut, MWArray stats_inversion)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawAeronetInversions", stats_inversion);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawAeronetInversions(int numArgsOut, MWArray stats_inversion, 
                                     MWArray r)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawAeronetInversions", stats_inversion, r);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the DrawAeronetInversions
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// eval(['print -dtiff e:\qa\Research_result\Ulumqi_cimel\fig_aeronet_inversion_'
    /// num2str(yy) strmm(mm,:) strdd(dd,:) '.tiff']);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="outputbase">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawAeronetInversions(int numArgsOut, MWArray stats_inversion, 
                                     MWArray r, MWArray outputbase)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawAeronetInversions", stats_inversion, r, outputbase);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    ///
    public void DrawSSA()
    {
      mcr.EvaluateFunction(0, "DrawSSA", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    ///
    public void DrawSSA(MWArray stats_inversion)
    {
      mcr.EvaluateFunction(0, "DrawSSA", stats_inversion);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    ///
    public void DrawSSA(MWArray stats_inversion, MWArray r)
    {
      mcr.EvaluateFunction(0, "DrawSSA", stats_inversion, r);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    ///
    public void DrawSSA(MWArray stats_inversion, MWArray r, MWArray year)
    {
      mcr.EvaluateFunction(0, "DrawSSA", stats_inversion, r, year);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    ///
    public void DrawSSA(MWArray stats_inversion, MWArray r, MWArray year, MWArray region)
    {
      mcr.EvaluateFunction(0, "DrawSSA", stats_inversion, r, year, region);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <param name="outputbase">Input argument #5</param>
    ///
    public void DrawSSA(MWArray stats_inversion, MWArray r, MWArray year, MWArray region, 
                  MWArray outputbase)
    {
      mcr.EvaluateFunction(0, "DrawSSA", stats_inversion, r, year, region, outputbase);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut, MWArray stats_inversion)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", stats_inversion);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut, MWArray stats_inversion, MWArray r)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", stats_inversion, r);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut, MWArray stats_inversion, MWArray r, MWArray 
                       year)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", stats_inversion, r, year);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut, MWArray stats_inversion, MWArray r, MWArray 
                       year, MWArray region)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", stats_inversion, r, year, region);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the DrawSSA M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// ssa月平均
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <param name="outputbase">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSA(int numArgsOut, MWArray stats_inversion, MWArray r, MWArray 
                       year, MWArray region, MWArray outputbase)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSA", stats_inversion, r, year, region, outputbase);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    ///
    public void DrawSSAStatistisc()
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    ///
    public void DrawSSAStatistisc(MWArray stats_inversion)
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", stats_inversion);
    }


    /// <summary>
    /// Provides a void output, 2-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    ///
    public void DrawSSAStatistisc(MWArray stats_inversion, MWArray r)
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", stats_inversion, r);
    }


    /// <summary>
    /// Provides a void output, 3-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    ///
    public void DrawSSAStatistisc(MWArray stats_inversion, MWArray r, MWArray year)
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", stats_inversion, r, year);
    }


    /// <summary>
    /// Provides a void output, 4-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    ///
    public void DrawSSAStatistisc(MWArray stats_inversion, MWArray r, MWArray year, 
                            MWArray region)
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", stats_inversion, r, year, region);
    }


    /// <summary>
    /// Provides a void output, 5-input MWArrayinterface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <param name="outputbase">Input argument #5</param>
    ///
    public void DrawSSAStatistisc(MWArray stats_inversion, MWArray r, MWArray year, 
                            MWArray region, MWArray outputbase)
    {
      mcr.EvaluateFunction(0, "DrawSSAStatistisc", stats_inversion, r, year, region, outputbase);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut, MWArray stats_inversion)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", stats_inversion);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut, MWArray stats_inversion, MWArray r)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", stats_inversion, r);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut, MWArray stats_inversion, MWArray 
                                 r, MWArray year)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", stats_inversion, r, year);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut, MWArray stats_inversion, MWArray 
                                 r, MWArray year, MWArray region)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", stats_inversion, r, year, region);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the DrawSSAStatistisc
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 绘图
    /// ssa
    /// figure;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="stats_inversion">Input argument #1</param>
    /// <param name="r">Input argument #2</param>
    /// <param name="year">Input argument #3</param>
    /// <param name="region">Input argument #4</param>
    /// <param name="outputbase">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] DrawSSAStatistisc(int numArgsOut, MWArray stats_inversion, MWArray 
                                 r, MWArray year, MWArray region, MWArray outputbase)
    {
      return mcr.EvaluateFunction(numArgsOut, "DrawSSAStatistisc", stats_inversion, r, year, region, outputbase);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the MatrixAeronet
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixAeronet()
    {
      return mcr.EvaluateFunction("MatrixAeronet", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the MatrixAeronet
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="lat">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixAeronet(MWArray lat)
    {
      return mcr.EvaluateFunction("MatrixAeronet", lat);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the MatrixAeronet
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixAeronet(MWArray lat, MWArray lon)
    {
      return mcr.EvaluateFunction("MatrixAeronet", lat, lon);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the MatrixAeronet
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <param name="input">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixAeronet(MWArray lat, MWArray lon, MWArray input)
    {
      return mcr.EvaluateFunction("MatrixAeronet", lat, lon, input);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the MatrixAeronet
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <param name="input">Input argument #3</param>
    /// <param name="outputfile">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixAeronet(MWArray lat, MWArray lon, MWArray input, MWArray 
                           outputfile)
    {
      return mcr.EvaluateFunction("MatrixAeronet", lat, lon, input, outputfile);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the MatrixAeronet M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixAeronet(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixAeronet", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the MatrixAeronet M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="lat">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixAeronet(int numArgsOut, MWArray lat)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixAeronet", lat);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the MatrixAeronet M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixAeronet(int numArgsOut, MWArray lat, MWArray lon)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixAeronet", lat, lon);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the MatrixAeronet M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <param name="input">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixAeronet(int numArgsOut, MWArray lat, MWArray lon, MWArray 
                             input)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixAeronet", lat, lon, input);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the MatrixAeronet M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="lat">Input argument #1</param>
    /// <param name="lon">Input argument #2</param>
    /// <param name="input">Input argument #3</param>
    /// <param name="outputfile">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixAeronet(int numArgsOut, MWArray lat, MWArray lon, MWArray 
                             input, MWArray outputfile)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixAeronet", lat, lon, input, outputfile);
    }


    /// <summary>
    /// Provides an interface for the MatrixAeronet function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 读取AERONET反演产品
    /// lat: the lat of the region
    /// lon: the lot of the region
    /// input: the base input folder of region
    /// outputfile: the outputfile
    /// clear;
    /// move to arg
    /// stns_fn='hangzhou';
    /// move to arg
    /// stns_id='808';
    /// YearInCount=2013;
    /// fout=['h:\CARSNET_INVERSION\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// fout=['E:\development\CIMEL_NETWORK\' stns_fn '\dubovik\'];
    /// move the initial logic to C#
    /// fout=output;
    /// if ~exist(fout,'dir')
    /// mkdir(fout);
    /// end
    /// fpath=['E:\QA\AERONET_INVERSION\output\' stns_fn '\'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void MatrixAeronet(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("MatrixAeronet", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
