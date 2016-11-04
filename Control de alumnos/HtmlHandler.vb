Imports System.IO

Public Class HtmlHandler
    Dim html As String
    Function createHtml()
        html = "<!DOCTYPE html><html><head>	<meta charset='utf-8'><title>Reporte grupal</title>	<style type='text/css'>		.cc{ width:40%;}table,tr,td{border: solid black;background: white;color: black;			font-size: 12pt;		}		body{			background: rgb(30,30,40);		}		*{			font-family: arial;		}	.container{			background: black;			width: 100%;			height: 100%;			color:white;		}		.n{			width: 1%;		}		.progress{			height: 100%;		}		#reporte{			width: 90%;			margin-left:5%;		}		.titulo{			text-align: center;			text-decoration:underline;		font-weight: bold;		background: gray;}	.h{				font-size: 15pt;		text-decoration: underline;color: white;}		</style></head><body>"
        Return 0
    End Function
    Function setTag(ByVal e As String)
        html += "<div class='h'>" + e + "<div><br>"
        Return 0
    End Function

    Function initTable()
        html += "<table id='reporte'><tr><td class='titulo cc'>Nombre:</td><td class='titulo'>Avanze acomulado:</td><td class='n titulo'>Estado:</td></tr>"
        Return 0
    End Function

    Function endTable()
        html += "</table>"
        Return 0
    End Function

    Function finishHtml()
        html += "</body></html>"
        Return 0
    End Function

    Function setTableRaw(ByVal nombre As String, ByVal avance As String)
        Dim color As String = ""
        Dim estado As String = ""
        Dim n As Decimal = Val(avance)
        If Val(avance) <= 50 Then
            color = "RED"
            estado = "REPROBADO"
        ElseIf Val(avance) > 50 And Val(avance) < 70 Then
            color = "ORANGE"
            estado = "REPROBADO"
        ElseIf Val(avance) >= 70 Then
            color = "GREEN"
            estado = "APROBADO"
        ElseIf Val(avance) = 0 Then
            estado = "REPROBADO"
            n = n + 1
            color = "RED"
        End If
        html += "<tr><td class='cc'>" + nombre + "</td><td><div class='container'><div class='progress' style='width: " + n.ToString + "%; background:" + color + ";'>" + avance + "%</div></div></td><td class='n'>" + estado + "</td></tr>"
        Return 0
    End Function

    Function saveHtml(ByVal ruta As String)
        If ruta = "" Then
            Try
                Dim escritor As StreamWriter
                escritor = New StreamWriter(Application.StartupPath + "/temp/reporte.html")
                escritor.Write(html)
                escritor.Close()
            Catch ex As Exception
                MkDir("temp")
                Try
                    Dim escritor As StreamWriter
                    escritor = New StreamWriter(Application.StartupPath + "/temp/reporte.html")
                    escritor.Write(html)
                    escritor.Close()
                Catch ex2 As Exception
                    MsgBox("Error de IO (Entrada - Salida)" + vbCrLf + ex2.ToString)
                End Try
            End Try



        Else
            Try
                Dim escritor As StreamWriter
                escritor = New StreamWriter(ruta)
                escritor.Write(html)
                escritor.Close()
            Catch ex As Exception
                Try
                    MkDir("temp")
                Catch ex2 As Exception

                End Try

                Try
                    Dim escritor As StreamWriter
                    escritor = New StreamWriter(ruta)
                    escritor.Write(html)
                    escritor.Close()
                Catch ex2 As Exception
                    MsgBox("Error de IO (Entrada - Salida)" + vbCrLf + ex2.ToString)
                End Try
            End Try
        End If

        Return 0
    End Function
End Class
