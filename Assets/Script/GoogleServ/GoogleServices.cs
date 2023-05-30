using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

namespace Reducer
{
  public class GoogleServices : MonoBehaviour
  {
    private const string InfinityRecord = "CgkIk7_v44UOEAIQAQ";

    private const string CompanyRecord = "CgkIk7_v44UOEAIQAg";

    private const string ThreeDRecord = "CgkIk7_v44UOEAIQAw";

    private void Start()
    {
      PlayGamesPlatform.Activate();
      PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
      void ProcessAuthentication(SignInStatus status)
      {
        if (status == SignInStatus.Success)
        {

        }
        else
        {

        }
      }
    }
    public void ShowTableRecord()
    {
      Social.ShowLeaderboardUI();
    }
    public void SaveTableRecord(int record)
    {
      Social.ReportScore(record, InfinityRecord, (bool success) => { });
    }
    public void SaveTableRecordCompany(int record)
    {
      print("table");
      Social.ReportScore(record, CompanyRecord, (bool success) => { });
    }
    public void SaveTableRecord3D(int record)
    {
      print("table3d");
      Social.ReportScore(record, ThreeDRecord, (bool success) => { });
    }
    public void SignInGoogle()
    {
      PlayGamesPlatform.Activate();
      PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
      void ProcessAuthentication(SignInStatus status)
      {
        if (status == SignInStatus.Success)
        {

        }
        else
        {

        }
      }
    }
    public void SignOutGoogle()
    {

    }
  }
}
