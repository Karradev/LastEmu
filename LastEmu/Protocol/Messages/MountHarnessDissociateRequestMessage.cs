using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountHarnessDissociateRequestMessage : NetworkMessage
	{
		public const uint Id = 6696;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6696;
			}
		}

		public MountHarnessDissociateRequestMessage()
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