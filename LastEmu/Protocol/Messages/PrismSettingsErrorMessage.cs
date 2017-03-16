using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismSettingsErrorMessage : NetworkMessage
	{
		public const uint Id = 6442;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6442;
			}
		}

		public PrismSettingsErrorMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}