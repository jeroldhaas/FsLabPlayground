#load @"../../packages/FsLab/FsLab.fsx"
open FsLab
open Foogle
open Deedle
open FSharp.Data

#r @"../../packages/encog-dotnet-core/lib/net35/encog-core-cs.dll"
open Encog.App
open Encog.Bot
open Encog.Cloud
open Encog.Engine
open Encog.ML
open Encog.MathUtil
open Encog.Neural
open Encog.Parse
open Encog.Persist
open Encog.Plugin
open Encog.Util

#load @"Library.fs"
open FsLabPlayground


//
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// 
let wb = WorldBankData.GetDataContext()
let cz = wb.Countries.``Czech Republic``.Indicators
let eu = wb.Countries.``European Union``.Indicators
let po = wb.Countries.Poland.Indicators

let czschool = series cz.``School enrollment, tertiary (% gross)``
let euschool = series eu.``School enrollment, tertiary (% gross)``
let poschool = series po.``School enrollment, tertiary (% gross)``

abs (poschool - euschool)
|> Series.sort
|> Series.rev
|> Series.take 10