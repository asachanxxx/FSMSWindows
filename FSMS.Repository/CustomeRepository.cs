using Dapper;
using FSMS.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Repository
{
    public class CustomeRepository
    {

        private static string _connectionName;

        public static IEnumerable<RosterViewModel> GetFuelTypes(int did)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                   
                    return db.Query<RosterViewModel>("SP_GetAllShifts", new { did = did }, commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<TotalizeReadingViewModel> GetAllTotalizerForDay(int did, int sid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {

                    return db.Query<TotalizeReadingViewModel>("SP_GetTotalizerReadings", new { did = did , sid = sid}, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool CheckExistanceOFNozzelForDayInTotalizer(int did,int nozzid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    int xxint = db.QuerySingleOrDefault<int>("select id from TotalizeReadings where dayid = @did and Nozzelid=@nozzid", new { did = did, nozzid = nozzid });
                    if (xxint > 0) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static decimal GetNozzelFuelPrice(int nozzelid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    decimal xxint = db.QuerySingleOrDefault<decimal>("SELECT        F.UnitPrice FROM  dbo.Nozzles AS N INNER JOIN dbo.FuelTypes AS F ON N.FuelTypeId = F.Id WHERE   (N.Id = @nozzid)", new { nozzid = nozzelid });
                    return xxint;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static decimal GetNozzelTotalizerReading(int nozzelid)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    decimal xxint = db.QuerySingleOrDefault<decimal>("SELECT N.LastTotalizerReading FROM  dbo.Nozzles AS N  WHERE   (N.Id = @nozzid)", new { nozzid = nozzelid });
                    return xxint;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool CheckExistancePumperForNozzel(int did, int nozzid,int pumprid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    int xxint = db.QuerySingleOrDefault<int>("CheckExistancePumperForNozzel", new { did = did, NozzelID = nozzid , PumperID = pumprid },commandType:CommandType.StoredProcedure);
                    if (xxint > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static TotalizeReading GetTotalizerForDayNozzelShift(int did, int nozzid, int sid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<TotalizeReading>("SP_GetTotalizerForDayNozzelShift", new { did = did, nid = nozzid, sid = sid }, commandType: CommandType.StoredProcedure);
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int GetNozzelForPumperInGivenDay(int did,int pumprid,int sid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("SP_GetNozzelForPumperInGivenDay", new { did = did, sid = sid, pid = pumprid }, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int InitializeDailyPumperAssign(string DateStamp,string day)
        {

            try
            {
                 _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("Sp_InitializeDailyPumperAssign", new { DateStamp = DateStamp , day = day }, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      

        public static IEnumerable<DailyAssignWorkerDetails> GetDailyAssignWorkerDetails(int did, int sessionid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<DailyAssignWorkerDetails>("SP_GetDailyAssignWorkerDetails", new { did = did , sessionid= sessionid }, commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static string AssignPumperToNozzel(int did,int pimperID, int NozzelID, int DayAssignID , int SessionID)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    int x = db.Execute("SP_AssignPumperToNozzel", new { SessionID = SessionID, did = did, pimperID = pimperID, NozzelID= NozzelID, DayAssignID= DayAssignID }, commandType: CommandType.StoredProcedure);
                    if (x > 0)
                    {
                        return "Pumper Assigned Successfull";
                    }
                    else {
                        return "Error While Pumper Assignement";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

      

        public static int InsertTotalCashCollection(int did,int pumperid, decimal cashtotal, decimal Cardtotal, decimal Vouchertotal, decimal Expensetotal)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("SP_InsertTotalCashCollection", 
                        new {
                            did = did,
                            pumperid = pumperid,
                            cashtotal = cashtotal,
                            Cardtotal = Cardtotal,
                            Vouchertotal = Vouchertotal,
                            Expensetotal = Expensetotal,
                        },
                        commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int InsertCollectionBreakdown(decimal value, int did, int pumperid, int collectionID, int vehicleID,
            int SalesId, string cardNo, string VoucherNO, int BankId,int Aciion,int CollectionBreakId, int SessionID)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("SP_InsertCollectionBreakdown",
                        new
                        {
                            DayID = did,
                            PumperId = pumperid,
                            CollectionId = collectionID,
                            vehicleId = vehicleID,
                            SaleID = SalesId,
                            CardNo = cardNo,
                            VoucherNo = VoucherNO,
                            BankId = BankId,
                            Action = Aciion,
                            Value = value,
                            CollectionBreakId= CollectionBreakId,
                            SessionID = SessionID
                        },
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int RemoveCollectionBreakdown(int CollectionBreakId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("SP_InsertCollectionBreakdown",
                        new
                        {
                            DayID = 0,
                            PumperId = 0,
                            CollectionId = 0,
                            vehicleId = 0,
                            SaleID = 0,
                            CardNo = "",
                            VoucherNo = "",
                            BankId = 0,
                            Action = 4,
                            Value = 1,
                            CollectionBreakId = CollectionBreakId
                        },
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public static DayPumperSaleTypeSummry GetTotalForEachPumperForGivenDay(int DayID, int PumperId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingle<DayPumperSaleTypeSummry>("SP_GetTotalForEachPumperForGivenDay",
                        new
                        {
                            DayID = DayID,
                            PumperId = PumperId
                        },
                        commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static IEnumerable<PumperForGivenDayCollectionDetails> PumperForGivenDayCollectionDetails(int DayID, int PumperId,int SaleType)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<PumperForGivenDayCollectionDetails>("SP_GetPumperForGivenDayCollectionDetails",
                        new
                        {
                            DayID = DayID,
                            PumperId = PumperId,
                            SaleType= SaleType
                        },
                        commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static PumpClosing GetPumpClosingDetails(int DayID, int PumperId, bool isPrcossed, int nozzelId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<PumpClosing>("SP_GetPumpClosingDet",
                        new
                        {
                            DayID = DayID,
                            PumperId = PumperId,
                            isPrcossed = isPrcossed,
                            nozzelId = nozzelId
                        },
                        commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

      

        public static int InsetPumpClosing(int DayID, int PumperId, int NozzelID, 
             decimal TotalHours, decimal StartTotalizer, decimal EndTotalizer, decimal Reading, decimal Price, decimal Value, int SeqNo,int SessionId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("SP_InsetPumpClosing",
                        new
                        {
                            DayID = DayID,
                            PumperId = PumperId,
                            NozzelID = NozzelID,
                            TotalHours = TotalHours,
                            StartTotalizer = StartTotalizer,
                            EndTotalizer = EndTotalizer,
                            Reading = Reading,
                            Price = Price,
                            Value = Value,
                            SeqNo= SeqNo,
                            SessionId = SessionId
                        },
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static IEnumerable<DailyPumperTotal> GetDailyPumperTotal(int DayID, int PumperId,int SessionId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<DailyPumperTotal>("SP_GetDailyPumperTotal",
                        new
                        {
                            DayId = DayID,
                            PumperId = PumperId,
                            SessionId= SessionId
                        },
                        commandType: CommandType.StoredProcedure);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public static GetCollectionFOrDay_Pumper_SaleType GetGetCollectionFOrDay_Pumper_SaleType(int DayID, int PumperId, int SaleId,int SessionId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    using (var multi = new SqlConnection(_connectionName).QueryMultiple("SP_GetCollectionFOrDay_Pumper_SaleType", new
                    {
                        DayId = DayID,
                        PumperId = PumperId,
                        SaleId = SaleId,
                        SessionId= SessionId
                    }, commandType: CommandType.StoredProcedure))
                    {
                        var countA = multi.Read<GetCollectionFOrDay_Pumper_SaleType>().Single();
                        var countB = multi.Read<GetCollectionFOrDay_Pumper_SaleType_Breakdown>();
                        countA.Breaks = countB;
                        return countA;
                    }

                    

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<TwoKeyValue> GetNozzelsForPumperOnGivenDay(int DayID, int PumperId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<TwoKeyValue>("SP_GetNozzelsForPumperOnGivenDay", new
                    {
                        DayId = DayID,
                        PumperId = PumperId
                    }, commandType: CommandType.StoredProcedure);



                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static TwoKeyNumer GetSystemTotalForPumperForDay(int DayID, int PumperId,int SessionId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<TwoKeyNumer>("SP_GetSystemTotalForPumperForDay", new
                    {
                        DayId = DayID,
                        PumperId = PumperId,
                        SessionId= SessionId
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static IEnumerable<Tank> GetAllTanks()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<Tank>("SELECT        dbo.Tanks.*         FROM dbo.Tanks");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<Nozzle> GetAllNozzelssByTank(int tankid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<Nozzle>("select * from Nozzles where TankId = @tankid" , new { tankid = tankid });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<Nozzle> GetNozzelsOFTanks(int tankid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<Nozzle>("SELECT  N.Id, N.PumpId, N.TankId, N.FuelTypeId, N.NozzelName, N.UnitPrice, N.LastTotalizerReading, N.GroupOfCompanyID, N.CreatedUser, N.CreatedDate, N.ModifiedUser, N.ModifiedDate, N.DataTransfer FROM            dbo.Tanks AS T INNER JOIN  dbo.Nozzles AS N ON T.Id = N.TankId WHERE (T.Id = @tankid)",
                        new { tankid = tankid }
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CheckForUnclosedDays()
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("select count(*) from DayMasters where IsCompleted = 0");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int InsertSalesPrint(DifferentLog entity)
        {

            try
            {
                XMLTool xmlcreate = new XMLTool();
                string xmlString = xmlcreate.Serialize(entity);

                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    var resfult = db.QuerySingle<DifferentLog>("SP_UpdateSalesEntries", new { XMLDetails = xmlString }, commandType: CommandType.StoredProcedure);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<DaySession> GetDaySessionForDay(int DayID)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<DaySession>("select Id , SessionName as 'Name' from [dbo].[DaySessions] where DayId =@DayID",
                        new { DayID = DayID }
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int IsNozzelAssignedOn(int DayID, int sessionid, int pumpid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("select PumperID from DayAssignWorkers where DayID =@DayID and SessionID = @sessionid  and NozzelID = @pumpid",
                        new
                        {
                            DayID = DayID,
                            sessionid = sessionid,
                            pumpid = pumpid
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static int IsExistsDifferentLog(int DayID, int sessionid, int pumpid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("select count(*) from DifferentLogs where DayID = @DayID and sessionid = @sessionid and PumperId = @pumpid",
                        new
                        {
                            DayID = DayID,
                            sessionid = sessionid,
                            pumpid = pumpid
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //select count(*) from DifferentLogs where DayID = 1 and sessionid = 0 and PumperId = 1
        public static string GetSetDocumentNumber(string ScreenID, int Serial, string Prefix, int mode)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    if (mode == 1)
                    {
                        return db.QuerySingleOrDefault<string>("GetSetDocumentNumber",
                            new
                            {
                                ScreenID = ScreenID,
                                Serial = Serial,
                                Prefix = Prefix,
                                mode = 1
                            },
                            commandType: CommandType.StoredProcedure
                            );
                    }
                    else
                    {
                        db.Execute("GetSetDocumentNumber",
                            new
                            {
                                ScreenID = ScreenID,
                                Serial = Serial,
                                Prefix = Prefix,
                                mode = 1
                            },
                            commandType: CommandType.StoredProcedure
                            );
                        return "Done";
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static int InitializeUnloading(string DocNo, int CreatedUser)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("SP_InitializeUnloading",
                        new
                        {
                            DocNo = DocNo,
                            CreatedUser = CreatedUser,
                        },commandType:CommandType.StoredProcedure
                        );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<UnloadingDipReadings> GetAllTanksForUnloading(string DocNo)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<UnloadingDipReadings>("SP_GetTanksForUnloading" , new { DocNo = DocNo }, commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<UnloadingNozzelReading> GetAllNozzelssByTankForUnloading(string DocNo, int TankId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<UnloadingNozzelReading>("SP_GetNozzelForUnloading", new { DocNo = DocNo, TankId = TankId }, commandType:CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int SaveTotalizerForUnloading(string DocNo, int NozzelID, decimal Reading)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("SP_SaveTotalizerForUnloading", 
                        new { DocNo = DocNo, NozzelID = NozzelID, Reading= Reading },
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int CheckForDocumentNo(string DocNo)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("select count(*) from [dbo].[UnloadingHeds] where DocNo = @DocNo",
                        new { DocNo = DocNo }
                      );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static decimal GetNozzelTotalizerReadings(string DocNo, int nozzelid)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("select top 1 Reading from UnloadingNozzelReadings inner " +
                        " join UnloadingHeds on UnloadingNozzelReadings.hedid = UnloadingHeds.id where UnloadingHeds.DocNo = @DocNo and NozzelId = @nozzelid",
                        new { DocNo = DocNo , nozzelid = nozzelid }
                      );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int UpdateDipValues(string DocNo,int TankID , decimal Value,int BorA)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingleOrDefault<int>("SP_SaveDipMesurements",
                        new { DocNo = DocNo, TankID = TankID , Reading = Value, BeforeAfter = BorA },
                        commandType:CommandType.StoredProcedure
                      );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static decimal GetNozzelTotalizerReadings(string DocNo, int Tankid, int beforeorafter)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    if (beforeorafter == 1)
                    {
                        return db.QuerySingleOrDefault<decimal>("select top 1 BeforeDipReading from UnloadingDipReadings inner join UnloadingHeds on UnloadingDipReadings.hedid = UnloadingHeds.id " +
                            "where UnloadingHeds.DocNo = @DocNo and TankD =@Tankid",
                            new { DocNo = DocNo, Tankid = Tankid }
                          );
                    }
                    else {
                        return db.QuerySingleOrDefault<decimal>("select top 1 AfterDipReading from UnloadingDipReadings inner join UnloadingHeds on UnloadingDipReadings.hedid = UnloadingHeds.id " +
                           "where UnloadingHeds.DocNo = @DocNo and TankD =@Tankid",
                           new { DocNo = DocNo, Tankid = Tankid }
                         );
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static FuelType GetFuelRecord(int FuelId)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingle<FuelType>("select top 1 * from FuelTypes where Id =@FuelId", new { FuelId = FuelId});
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<Vehicle> GetVehicleForCustomers(int Cusid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Query<Vehicle>("select * from [dbo].[Vehicles] where CreditCusId =@Cusid", new { Cusid = Cusid });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int ClosePump(int DayID)
        {
            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.Execute("update DayMasters set IsCompleted = 1 where Id = @DayID", new { DayID = DayID });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Customer GetCustomerDetails(int Cusid)
        {

            try
            {
                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    return db.QuerySingle<Customer>("select top 1 * from Customers where Id =@Cusid", new { Cusid = Cusid });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int InsertReciept(ReceiptHed entity)
        {

            try
            {
                XMLTool xmlcreate = new XMLTool();
                string xmlString = xmlcreate.Serialize(entity);

                _connectionName = ConfigurationManager.ConnectionStrings["ConnFSMS"].ConnectionString;
                using (IDbConnection db = new SqlConnection(_connectionName))
                {
                    var resfult = db.QuerySingle<int>("SP_SaveReciept", new { XMLDetails = xmlString }, commandType: CommandType.StoredProcedure);
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
