using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LeaveDialogRequestMessage : NetworkMessage
	{
		public const uint Id = 5501;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5501;
			}
		}

		public LeaveDialogRequestMessage()
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