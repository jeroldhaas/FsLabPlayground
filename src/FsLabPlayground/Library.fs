namespace FsLabPlayground

// Encog
open Encog.App
open Encog.Bot
open Encog.Cloud
open Encog.Engine
open Encog.ML
open Encog.Neural
open Encog.Parse
open Encog.Persist

// Encog Utils
open Encog.MathUtil
open Encog.Util

/// Documentation for my library
///
/// ## Example
///
///     let h = Library.hello 1
///     printfn "%d" h
///
module Library = 
  
  /// Returns 42
  ///
  /// ## Parameters
  ///  - `num` - whatever
  let hello num = 42
