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
					<h1>DANH SÁCH KHÁCH HÀNG</h1>
				</center>

				<br />

				<br />
				<table border="1" width="100%">
					<tr>
						<th>STT</th>
						<th>Mã khách hàng</th>
						<th>Tên khách hàng</th>
						<th>CMND</th>
						<th>Địa Chỉ</th>
						<th>Giới tính</th>
						<th>Ngày sinh</th>
						<th>Số điện thoại</th>
						<th>Ngày đăng kí</th>
					
					</tr>
					<xsl:for-each select="_x0027_tb_HoTieuThu_x0027_">

						<tr>
							<td>
								<xsl:value-of select="position()"/>
							</td>
							<td>
								<xsl:value-of select="makh"/>
							</td>
							<td>
								<xsl:value-of select="hoten"/>
							</td>
							<td>
								<xsl:value-of select="cmt"/>
							</td>
							<td>
								<xsl:value-of select="diachi"/>
							</td>
							<td>
								<xsl:value-of select="gioitinh"/>
							</td>
							<td>
								<xsl:value-of select="ngaysinh"/>
							</td>
							<td>
								<xsl:value-of select="sodt"/>
							</td>
							<td>
								<xsl:value-of select="ngaydk"/>
							</td>
						</tr>
						
					</xsl:for-each>
				</table>
				
				<h3 style ="float:right">Người lập : HƯƠNG</h3>
			</body>
		</html>

    </xsl:template>
</xsl:stylesheet>
