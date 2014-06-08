/*
 * DSS - Digital Signature Services
 *
 * Copyright (C) 2011 European Commission, Directorate-General Internal Market and Services (DG MARKT), B-1049 Bruxelles/Brussel
 *
 * Developed by: 2011 ARHS Developments S.A. (rue Nicolas BovÃ© 2B, L-1253 Luxembourg) http://www.arhs-developments.com
 *
 * This file is part of the "DSS - Digital Signature Services" project.
 *
 * "DSS - Digital Signature Services" is free software: you can redistribute it and/or modify it under the terms of
 * the GNU Lesser General Public License as published by the Free Software Foundation, either version 2.1 of the
 * License, or (at your option) any later version.
 *
 * DSS is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License along with
 * "DSS - Digital Signature Services".  If not, see <http://www.gnu.org/licenses/>.
 */

using Org.BouncyCastle.X509;

namespace EU.Europa.EC.Markt.Dss.Validation.Certificate
{
    /// <summary>The AIA CertificateSource must be created for each certificate.</summary>
    /// <remarks>
    /// The AIA CertificateSource must be created for each certificate. The CertificateSourceFactory create such source
    /// provided a X509 Certificate.
    /// </remarks>
    /// <version>$Revision: 1887 $ - $Date: 2013-04-23 14:56:09 +0200 (mar., 23 avr. 2013) $
    /// 	</version>
    public interface CertificateSourceFactory
    {
        /// <summary>Return a new CertificateSource that retrieve certificates according the AIA attribute.
        /// 	</summary>
        /// <remarks>Return a new CertificateSource that retrieve certificates according the AIA attribute.
        /// 	</remarks>
        /// <param name="certificate"></param>
        /// <returns></returns>
        CertificateSource CreateAIACertificateSource(X509Certificate certificate);
    }
}
