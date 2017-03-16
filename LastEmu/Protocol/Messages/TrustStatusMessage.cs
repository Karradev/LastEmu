using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class TrustStatusMessage : NetworkMessage
	{
		public const uint Id = 6267;

		public bool trusted;

		public bool certified;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6267;
			}
		}

		public TrustStatusMessage()
		{
		}

		public TrustStatusMessage(bool trusted, bool certified)
		{
			this.trusted = trusted;
			this.certified = certified;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.trusted = BooleanByteWrapper.GetFlag(num, 0);
			this.certified = BooleanByteWrapper.GetFlag(num, 1);
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.trusted);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.certified));
		}
	}
}