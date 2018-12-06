Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace LinqsortTest
    Class Data
        Public gakuseibangou As Integer
        Public sei As String
        Public name As String

        Public Sub New(ByVal bangou As Integer, ByVal isei As String, ByVal iname As String)
            gakuseibangou = bangou
            sei = isei
            name = iname
        End Sub
    End Class

    Class Program
        Private Shared Sub Main(ByVal args As String())
            Dim gakuseimeibo = New Data() {New Data(14, "風浦", "可符香"), New Data(20, "小森", "霧"), New Data(22, "常月", "まとい"), New Data(19, "小節", "あびる"), New Data(18, "木村", "カエレ"), New Data(16, "音無", "芽留"), New Data(17, "木津", "千里"), New Data(8, "関内", "マリア"), New Data(28, "日塔", "奈美")}
            Dim syussekibnagouname = From p In gakuseimeibo Where p.gakuseibangou <= 15 Order By p.gakuseibangou Select p.name

            For Each name In syussekibnagouname
                Console.Write("{0}" & vbLf, name)
            Next
        End Sub
    End Class
End Namespace
