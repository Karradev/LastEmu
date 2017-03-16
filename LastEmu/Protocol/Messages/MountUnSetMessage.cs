using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountUnSetMessage : NetworkMessage
	{
		public const uint Id = 5982;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5982;
			}
		}

		public MountUnSetMessage()
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