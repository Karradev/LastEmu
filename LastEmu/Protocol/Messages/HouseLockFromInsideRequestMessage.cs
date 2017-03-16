using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
	{
		public const uint Id = 5885;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5885;
			}
		}

		public HouseLockFromInsideRequestMessage()
		{
		}

		public HouseLockFromInsideRequestMessage(string code) : base(code)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}