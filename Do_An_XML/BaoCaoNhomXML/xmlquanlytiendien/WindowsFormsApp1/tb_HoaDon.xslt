<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/NewDataSet">
		<html>
			<body>
				<br />
				<br />
				<center>
					<h1>DANH SÁCH HOÁ ĐƠN</h1>
				</center>

				<br />

				<br />
				<table border="1" width="100%">
					<tr>
						<th>STT</th>
						<th>Mã hoá đơn</th>
						<th>Mã khách hàng</th>
						<th>lượng điện tiêu thụ</th>
            <th>loại điện</th>
						<th>Thành tiền</th>
						

					</tr>
					<xsl:for-each select="_x0027_tb_HoaDon_x0027_">

						<tr>
							<td>
								<xsl:value-of select="position()"/>
							</td>
							<td>
								<xsl:value-of select="mahd"/>
							</td>
							<td>
								<xsl:value-of select="makh"/>
							</td>
							<td>
								<xsl:value-of select="luongdientt"/>
							</td>
              <td>
                <xsl:value-of select="loaidien"/>
              </td>
							<td>
								<xsl:value-of select="thanhtien"/>
							</td>
						
						</tr>

					</xsl:for-each>
				</table>

				<h3 style ="float:right">Người lập : NHÂN</h3>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
