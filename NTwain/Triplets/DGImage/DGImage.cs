﻿using System;
namespace NTwain.Triplets
{
	/// <summary>
	/// Class for grouping triplet operations under the Image data group.
	/// </summary>
	public sealed class DGImage
	{
		TwainSession _session;
		internal DGImage(TwainSession session)
		{
			if (session == null) { throw new ArgumentNullException("session"); }
			_session = session;
		}

		CieColor _cieColor;
		public CieColor CieColor
		{
			get
			{
				if (_cieColor == null) { _cieColor = new CieColor(_session); }
				return _cieColor;
			}
		}


		ExtImageInfo _extImgInfo;
		public ExtImageInfo ExtImageInfo
		{
			get
			{
				if (_extImgInfo == null) { _extImgInfo = new ExtImageInfo(_session); }
				return _extImgInfo;
			}
		}

		GrayResponse _grayResponse;
		public GrayResponse GrayResponse
		{
			get
			{
				if (_grayResponse == null) { _grayResponse = new GrayResponse(_session); }
				return _grayResponse;
			}
		}

		IccProfile _iccProfile;
		public IccProfile IccProfile
		{
			get
			{
				if (_iccProfile == null) { _iccProfile = new IccProfile(_session); }
				return _iccProfile;
			}
		}

		ImageFileXfer _imgFileXfer;
		internal ImageFileXfer ImageFileXfer
		{
			get
			{
				if (_imgFileXfer == null) { _imgFileXfer = new ImageFileXfer(_session); }
				return _imgFileXfer;
			}
		}

		ImageInfo _imgInfo;
		public ImageInfo ImageInfo
		{
			get
			{
				if (_imgInfo == null) { _imgInfo = new ImageInfo(_session); }
				return _imgInfo;
			}
		}

		ImageLayout _imgLayout;
		public ImageLayout ImageLayout
		{
			get
			{
				if (_imgLayout == null) { _imgLayout = new ImageLayout(_session); }
				return _imgLayout;
			}
		}

		ImageMemFileXfer _imgMemFileXfer;
		internal ImageMemFileXfer ImageMemFileXfer
		{
			get
			{
				if (_imgMemFileXfer == null) { _imgMemFileXfer = new ImageMemFileXfer(_session); }
				return _imgMemFileXfer;
			}
		}

		ImageMemXfer _imgMemXfer;
		internal ImageMemXfer ImageMemXfer
		{
			get
			{
				if (_imgMemXfer == null) { _imgMemXfer = new ImageMemXfer(_session); }
				return _imgMemXfer;
			}
		}

		ImageNativeXfer _imgNativeXfer;
		internal ImageNativeXfer ImageNativeXfer
		{
			get
			{
				if (_imgNativeXfer == null) { _imgNativeXfer = new ImageNativeXfer(_session); }
				return _imgNativeXfer;
			}
		}

		JpegCompression _jpegComp;
		public JpegCompression JpegCompression
		{
			get
			{
				if (_jpegComp == null) { _jpegComp = new JpegCompression(_session); }
				return _jpegComp;
			}
		}

		Palette8 _palette8;
		public Palette8 Palette8
		{
			get
			{
				if (_palette8 == null) { _palette8 = new Palette8(_session); }
				return _palette8;
			}
		}

		RgbResponse _rgbResp;
		public RgbResponse RgbResponse
		{
			get
			{
				if (_rgbResp == null) { _rgbResp = new RgbResponse(_session); }
				return _rgbResp;
			}
		}

		

	}
}