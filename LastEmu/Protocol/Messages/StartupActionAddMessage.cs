using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StartupActionAddMessage : NetworkMessage
	{
		public const uint Id = 6538;

		public StartupActionAddObject newAction;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6538;
			}
		}

		public StartupActionAddMessage()
		{
		}

		public StartupActionAddMessage(StartupActionAddObject newAction)
		{
			this.newAction = newAction;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.newAction = new StartupActionAddObject();
			this.newAction.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.newAction.Serialize(writer);
		}
	}
}